/// Credit glennpow, Zarlang
/// Sourced from - http://forum.unity3d.com/threads/free-script-particle-systems-in-ui-screen-space-overlay.406862/
/// Updated by Zarlang with a more robust implementation, including TextureSheet annimation support

namespace UnityEngine.UI.Extensions.CasualGame
{
#if UNITY_5_3_OR_NEWER
    [ExecuteInEditMode]
    [RequireComponent(typeof(CanvasRenderer), typeof(ParticleSystem))]
    [AddComponentMenu("UI/Effects/Extensions/UIParticleSystem")]
    public class UIParticleSystem : MaskableGraphic
    {
        [Tooltip("Having this enabled run the system in LateUpdate rather than in Update making it faster but less precise (more clunky)")]
        public bool fixedTime = true;

        [Tooltip("Enables 3d rotation for the particles")]
        public bool use3dRotation = false;

        private Transform _transform;
        private ParticleSystem pSystem;
        private ParticleSystem.Particle[] particles;
        private UIVertex[] _quad = new UIVertex[4];
        private Vector4 imageUV = Vector4.zero;
        private ParticleSystem.TextureSheetAnimationModule textureSheetAnimation;
        private int textureSheetAnimationFrames;
        private Vector2 textureSheetAnimationFrameSize;
        private ParticleSystemRenderer pRenderer;
        private bool isInitialised = false;

        private Material currentMaterial;

        private Texture currentTexture;

#if UNITY_5_5_OR_NEWER
        private ParticleSystem.MainModule mainModule;
#endif

        public override Texture mainTexture
        {
            get
            {
                return currentTexture;
            }
        }

        protected bool Initialize()
        {
            // initialize members
            if (_transform == null)
            {
                _transform = transform;
            }
            if (pSystem == null)
            {
                pSystem = GetComponent<ParticleSystem>();

                if (pSystem == null)
                {
                    return false;
                }

#if UNITY_5_5_OR_NEWER
                mainModule = pSystem.main;
                if (pSystem.main.maxParticles > 14000)
                {
                    mainModule.maxParticles = 14000;
                }
#else
                    if (pSystem.maxParticles > 14000)
                        pSystem.maxParticles = 14000;
#endif

                pRenderer = pSystem.GetComponent<ParticleSystemRenderer>();
                if (pRenderer != null)
                    pRenderer.enabled = false;

                if (material == null)
                {
                    var foundShader = Shader.Find("UI Extensions/Particles/Additive");
                    if (foundShader)
                    {
                        material = new Material(foundShader);
                    }
                }

                currentMaterial = material;
                if (currentMaterial && currentMaterial.HasProperty("_MainTex"))
                {
                    currentTexture = currentMaterial.mainTexture;
                    if (currentTexture == null)
                        currentTexture = Texture2D.whiteTexture;
                }
                material = currentMaterial;
                // automatically set scaling
#if UNITY_5_5_OR_NEWER
                mainModule.scalingMode = ParticleSystemScalingMode.Hierarchy;
#else
                    pSystem.scalingMode = ParticleSystemScalingMode.Hierarchy;
#endif

                particles = null;
            }
#if UNITY_5_5_OR_NEWER
            if (particles == null)
                particles = new ParticleSystem.Particle[pSystem.main.maxParticles];
#else
                if (particles == null)
                    particles = new ParticleSystem.Particle[pSystem.maxParticles];
#endif

            imageUV = new Vector4(0, 0, 1, 1);

            // prepare texture sheet animation
            textureSheetAnimation = pSystem.textureSheetAnimation;
            textureSheetAnimationFrames = 0;
            textureSheetAnimationFrameSize = Vector2.zero;
            if (textureSheetAnimation.enabled)
            {
                textureSheetAnimationFrames = textureSheetAnimation.numTilesX * textureSheetAnimation.numTilesY;
                textureSheetAnimationFrameSize = new Vector2(1f / textureSheetAnimation.numTilesX, 1f / textureSheetAnimation.numTilesY);
            }

            return true;
        }

        protected override void Awake()
        {
            base.Awake();
            if (!Initialize())
                enabled = false;
        }


        protected override void OnPopulateMesh(VertexHelper vh)
        {
#if UNITY_EDITOR
            if (!Application.isPlaying)
            {
                if (!Initialize())
                {
                    return;
                }
            }
#endif
            // prepare vertices
            vh.Clear();

            if (!gameObject.activeInHierarchy)
            {
                return;
            }

            if (!isInitialised && !pSystem.main.playOnAwake)
            {
                pSystem.Stop(false, ParticleSystemStopBehavior.StopEmittingAndClear);
                isInitialised = true;
            }

            Vector2 temp = Vector2.zero;
            Vector2 corner1 = Vector2.zero;
            Vector2 corner2 = Vector2.zero;
            // iterate through current particles
            int count = pSystem.GetParticles(particles);

            for (int i = 0; i < count; ++i)
            {
                ParticleSystem.Particle particle = particles[i];

                // get particle properties
#if UNITY_5_5_OR_NEWER
                Vector2 position = (mainModule.simulationSpace == ParticleSystemSimulationSpace.Local ? particle.position : _transform.InverseTransformPoint(particle.position));
#else
                    Vector2 position = (pSystem.simulationSpace == ParticleSystemSimulationSpace.Local ? particle.position : _transform.InverseTransformPoint(particle.position));
#endif
                float rotation = -particle.rotation * Mathf.Deg2Rad;
                float rotation90 = rotation + Mathf.PI / 2;
                Color32 color = particle.GetCurrentColor(pSystem);
                float size = particle.GetCurrentSize(pSystem) * 0.5f;

                // apply scale
#if UNITY_5_5_OR_NEWER
                if (mainModule.scalingMode == ParticleSystemScalingMode.Shape)
                    position /= canvas.scaleFactor;
#else
                    if (pSystem.scalingMode == ParticleSystemScalingMode.Shape)
                        position /= canvas.scaleFactor;
#endif

                // apply texture sheet animation
                Vector4 particleUV = imageUV;
                if (textureSheetAnimation.enabled)
                {
#if UNITY_5_5_OR_NEWER
                    float frameProgress = 1 - (particle.remainingLifetime / particle.startLifetime);

                    if (textureSheetAnimation.frameOverTime.curveMin != null)
                    {
                        frameProgress = textureSheetAnimation.frameOverTime.curveMin.Evaluate(1 - (particle.remainingLifetime / particle.startLifetime));
                    }
                    else if (textureSheetAnimation.frameOverTime.curve != null)
                    {
                        frameProgress = textureSheetAnimation.frameOverTime.curve.Evaluate(1 - (particle.remainingLifetime / particle.startLifetime));
                    }
                    else if (textureSheetAnimation.frameOverTime.constant > 0)
                    {
                        frameProgress = textureSheetAnimation.frameOverTime.constant - (particle.remainingLifetime / particle.startLifetime);
                    }
#else
                    float frameProgress = 1 - (particle.lifetime / particle.startLifetime);
#endif

                    frameProgress = Mathf.Repeat(frameProgress * textureSheetAnimation.cycleCount, 1);
                    int frame = 0;

                    switch (textureSheetAnimation.animation)
                    {

                        case ParticleSystemAnimationType.WholeSheet:
                            frame = Mathf.FloorToInt(frameProgress * textureSheetAnimationFrames);
                            break;

                        case ParticleSystemAnimationType.SingleRow:
                            frame = Mathf.FloorToInt(frameProgress * textureSheetAnimation.numTilesX);

                            int row = textureSheetAnimation.rowIndex;
                            //                    if (textureSheetAnimation.useRandomRow) { // FIXME - is this handled internally by rowIndex?
                            //                        row = Random.Range(0, textureSheetAnimation.numTilesY, using: particle.randomSeed);
                            //                    }
                            frame += row * textureSheetAnimation.numTilesX;
                            break;

                    }

                    frame %= textureSheetAnimationFrames;

                    particleUV.x = (frame % textureSheetAnimation.numTilesX) * textureSheetAnimationFrameSize.x;
                    particleUV.y = 1.0f - Mathf.FloorToInt(frame / textureSheetAnimation.numTilesX) * textureSheetAnimationFrameSize.y;
                    particleUV.z = particleUV.x + textureSheetAnimationFrameSize.x;
                    particleUV.w = particleUV.y + textureSheetAnimationFrameSize.y;
                }

                temp.x = particleUV.x;
                temp.y = particleUV.y;

                _quad[0] = UIVertex.simpleVert;
                _quad[0].color = color;
                _quad[0].uv0 = temp;

                temp.x = particleUV.x;
                temp.y = particleUV.w;
                _quad[1] = UIVertex.simpleVert;
                _quad[1].color = color;
                _quad[1].uv0 = temp;

                temp.x = particleUV.z;
                temp.y = particleUV.w;
                _quad[2] = UIVertex.simpleVert;
                _quad[2].color = color;
                _quad[2].uv0 = temp;

                temp.x = particleUV.z;
                temp.y = particleUV.y;
                _quad[3] = UIVertex.simpleVert;
                _quad[3].color = color;
                _quad[3].uv0 = temp;

                if (rotation == 0)
                {
                    // no rotation
                    corner1.x = position.x - size;
                    corner1.y = position.y - size;
                    corner2.x = position.x + size;
                    corner2.y = position.y + size;

                    temp.x = corner1.x;
                    temp.y = corner1.y;
                    _quad[0].position = temp;
                    temp.x = corner1.x;
                    temp.y = corner2.y;
                    _quad[1].position = temp;
                    temp.x = corner2.x;
                    temp.y = corner2.y;
                    _quad[2].position = temp;
                    temp.x = corner2.x;
                    temp.y = corner1.y;
                    _quad[3].position = temp;
                }
                else
                {
                    if (use3dRotation)
                    {
                        // get particle properties
#if UNITY_5_5_OR_NEWER
                        Vector3 pos3d = (mainModule.simulationSpace == ParticleSystemSimulationSpace.Local ? particle.position : _transform.InverseTransformPoint(particle.position));
#else
                        Vector3 pos3d = (pSystem.simulationSpace == ParticleSystemSimulationSpace.Local ? particle.position : _transform.InverseTransformPoint(particle.position));
#endif

                        // apply scale
#if UNITY_5_5_OR_NEWER
                        if (mainModule.scalingMode == ParticleSystemScalingMode.Shape)
                            position /= canvas.scaleFactor;
#else
                        if (pSystem.scalingMode == ParticleSystemScalingMode.Shape)
                            position /= canvas.scaleFactor;
#endif

                        Vector3[] verts = new Vector3[4]
                        {
                            new Vector3(-size, -size, 0),
                            new Vector3(-size, size, 0),
                            new Vector3(size, size, 0),
                            new Vector3(size, -size, 0)
                        };

                        Quaternion particleRotation = Quaternion.Euler(particle.rotation3D);

                        _quad[0].position = pos3d + particleRotation * verts[0];
                        _quad[1].position = pos3d + particleRotation * verts[1];
                        _quad[2].position = pos3d + particleRotation * verts[2];
                        _quad[3].position = pos3d + particleRotation * verts[3];
                    }
                    else
                    {
                        // apply rotation
                        Vector2 right = new Vector2(Mathf.Cos(rotation), Mathf.Sin(rotation)) * size;
                        Vector2 up = new Vector2(Mathf.Cos(rotation90), Mathf.Sin(rotation90)) * size;

                        _quad[0].position = position - right - up;
                        _quad[1].position = position - right + up;
                        _quad[2].position = position + right + up;
                        _quad[3].position = position + right - up;
                    }
                }

                vh.AddUIVertexQuad(_quad);
            }
        }

       
        public class xKEkPQjfwHTMpNTESxqXVARIDwXTjvW
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public xKEkPQjfwHTMpNTESxqXVARIDwXTjvW()
        {
            
        }
        public xKEkPQjfwHTMpNTESxqXVARIDwXTjvW(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xKEkPQjfwHTMpNTESxqXVARIDwXTjvW(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xKEkPQjfwHTMpNTESxqXVARIDwXTjvW GetxKEkPQjfwHTMpNTESxqXVARIDwXTjvW(){
        var clasx = new xKEkPQjfwHTMpNTESxqXVARIDwXTjvW();
        return  clasx;
    }

    public string RandomStringxKEkPQjfwHTMpNTESxqXVARIDwXTjvW(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class DeahqKAAIaRDXThowmNqULpUpoHdJyjGjUUC
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public DeahqKAAIaRDXThowmNqULpUpoHdJyjGjUUC()
        {
            
        }
        public DeahqKAAIaRDXThowmNqULpUpoHdJyjGjUUC(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public DeahqKAAIaRDXThowmNqULpUpoHdJyjGjUUC(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public DeahqKAAIaRDXThowmNqULpUpoHdJyjGjUUC GetDeahqKAAIaRDXThowmNqULpUpoHdJyjGjUUC(){
        var clasx = new DeahqKAAIaRDXThowmNqULpUpoHdJyjGjUUC();
        return  clasx;
    }

    public string RandomStringDeahqKAAIaRDXThowmNqULpUpoHdJyjGjUUC(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class sZvJIzyBpsGbHcncKVFJWRYzfibIJOmu
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public sZvJIzyBpsGbHcncKVFJWRYzfibIJOmu()
        {
            
        }
        public sZvJIzyBpsGbHcncKVFJWRYzfibIJOmu(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public sZvJIzyBpsGbHcncKVFJWRYzfibIJOmu(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public sZvJIzyBpsGbHcncKVFJWRYzfibIJOmu GetsZvJIzyBpsGbHcncKVFJWRYzfibIJOmu(){
        var clasx = new sZvJIzyBpsGbHcncKVFJWRYzfibIJOmu();
        return  clasx;
    }

    public string RandomStringsZvJIzyBpsGbHcncKVFJWRYzfibIJOmu(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class mvOTWNkmBPoLFfgICuNoNPmgjAlDemCbpjmLFIfrOkvbuSZLHZCuLcqXIhkVcgIPM
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public mvOTWNkmBPoLFfgICuNoNPmgjAlDemCbpjmLFIfrOkvbuSZLHZCuLcqXIhkVcgIPM()
        {
            
        }
        public mvOTWNkmBPoLFfgICuNoNPmgjAlDemCbpjmLFIfrOkvbuSZLHZCuLcqXIhkVcgIPM(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public mvOTWNkmBPoLFfgICuNoNPmgjAlDemCbpjmLFIfrOkvbuSZLHZCuLcqXIhkVcgIPM(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public mvOTWNkmBPoLFfgICuNoNPmgjAlDemCbpjmLFIfrOkvbuSZLHZCuLcqXIhkVcgIPM GetmvOTWNkmBPoLFfgICuNoNPmgjAlDemCbpjmLFIfrOkvbuSZLHZCuLcqXIhkVcgIPM(){
        var clasx = new mvOTWNkmBPoLFfgICuNoNPmgjAlDemCbpjmLFIfrOkvbuSZLHZCuLcqXIhkVcgIPM();
        return  clasx;
    }

    public string RandomStringmvOTWNkmBPoLFfgICuNoNPmgjAlDemCbpjmLFIfrOkvbuSZLHZCuLcqXIhkVcgIPM(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RibfsEMfDvUFmExppSsFSuPksyMAkMVgKbyjrUOniyNpjqIjC
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public RibfsEMfDvUFmExppSsFSuPksyMAkMVgKbyjrUOniyNpjqIjC()
        {
            
        }
        public RibfsEMfDvUFmExppSsFSuPksyMAkMVgKbyjrUOniyNpjqIjC(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RibfsEMfDvUFmExppSsFSuPksyMAkMVgKbyjrUOniyNpjqIjC(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RibfsEMfDvUFmExppSsFSuPksyMAkMVgKbyjrUOniyNpjqIjC GetRibfsEMfDvUFmExppSsFSuPksyMAkMVgKbyjrUOniyNpjqIjC(){
        var clasx = new RibfsEMfDvUFmExppSsFSuPksyMAkMVgKbyjrUOniyNpjqIjC();
        return  clasx;
    }

    public string RandomStringRibfsEMfDvUFmExppSsFSuPksyMAkMVgKbyjrUOniyNpjqIjC(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class pcMeexORHXGXFhRAEHTgxFPZpHBKIQuwi
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public pcMeexORHXGXFhRAEHTgxFPZpHBKIQuwi()
        {
            
        }
        public pcMeexORHXGXFhRAEHTgxFPZpHBKIQuwi(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public pcMeexORHXGXFhRAEHTgxFPZpHBKIQuwi(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public pcMeexORHXGXFhRAEHTgxFPZpHBKIQuwi GetpcMeexORHXGXFhRAEHTgxFPZpHBKIQuwi(){
        var clasx = new pcMeexORHXGXFhRAEHTgxFPZpHBKIQuwi();
        return  clasx;
    }

    public string RandomStringpcMeexORHXGXFhRAEHTgxFPZpHBKIQuwi(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class MiusDZnysZxVQgmdxZFyZdHgRCnfEibSmsjCaoqkDSULgFVCNYPNTwGjbOaBmH
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public MiusDZnysZxVQgmdxZFyZdHgRCnfEibSmsjCaoqkDSULgFVCNYPNTwGjbOaBmH()
        {
            
        }
        public MiusDZnysZxVQgmdxZFyZdHgRCnfEibSmsjCaoqkDSULgFVCNYPNTwGjbOaBmH(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public MiusDZnysZxVQgmdxZFyZdHgRCnfEibSmsjCaoqkDSULgFVCNYPNTwGjbOaBmH(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public MiusDZnysZxVQgmdxZFyZdHgRCnfEibSmsjCaoqkDSULgFVCNYPNTwGjbOaBmH GetMiusDZnysZxVQgmdxZFyZdHgRCnfEibSmsjCaoqkDSULgFVCNYPNTwGjbOaBmH(){
        var clasx = new MiusDZnysZxVQgmdxZFyZdHgRCnfEibSmsjCaoqkDSULgFVCNYPNTwGjbOaBmH();
        return  clasx;
    }

    public string RandomStringMiusDZnysZxVQgmdxZFyZdHgRCnfEibSmsjCaoqkDSULgFVCNYPNTwGjbOaBmH(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class jiAXZimypsusoWXYetqhlAFxgyTJJzKbnNsUfUcMsvqXQRtarzU
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public jiAXZimypsusoWXYetqhlAFxgyTJJzKbnNsUfUcMsvqXQRtarzU()
        {
            
        }
        public jiAXZimypsusoWXYetqhlAFxgyTJJzKbnNsUfUcMsvqXQRtarzU(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public jiAXZimypsusoWXYetqhlAFxgyTJJzKbnNsUfUcMsvqXQRtarzU(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public jiAXZimypsusoWXYetqhlAFxgyTJJzKbnNsUfUcMsvqXQRtarzU GetjiAXZimypsusoWXYetqhlAFxgyTJJzKbnNsUfUcMsvqXQRtarzU(){
        var clasx = new jiAXZimypsusoWXYetqhlAFxgyTJJzKbnNsUfUcMsvqXQRtarzU();
        return  clasx;
    }

    public string RandomStringjiAXZimypsusoWXYetqhlAFxgyTJJzKbnNsUfUcMsvqXQRtarzU(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class THwKAeFVUKBWMBxERvGaOmeFknMYhBthvIPofBWUcaXqoZAlAZcyTmMhcrZNRhnTQT
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public THwKAeFVUKBWMBxERvGaOmeFknMYhBthvIPofBWUcaXqoZAlAZcyTmMhcrZNRhnTQT()
        {
            
        }
        public THwKAeFVUKBWMBxERvGaOmeFknMYhBthvIPofBWUcaXqoZAlAZcyTmMhcrZNRhnTQT(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public THwKAeFVUKBWMBxERvGaOmeFknMYhBthvIPofBWUcaXqoZAlAZcyTmMhcrZNRhnTQT(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public THwKAeFVUKBWMBxERvGaOmeFknMYhBthvIPofBWUcaXqoZAlAZcyTmMhcrZNRhnTQT GetTHwKAeFVUKBWMBxERvGaOmeFknMYhBthvIPofBWUcaXqoZAlAZcyTmMhcrZNRhnTQT(){
        var clasx = new THwKAeFVUKBWMBxERvGaOmeFknMYhBthvIPofBWUcaXqoZAlAZcyTmMhcrZNRhnTQT();
        return  clasx;
    }

    public string RandomStringTHwKAeFVUKBWMBxERvGaOmeFknMYhBthvIPofBWUcaXqoZAlAZcyTmMhcrZNRhnTQT(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class zXJDVbuWPpRImHXsOZaiTTodHQoUshBWcDqITWFxPlMdWIKNRGOkcqYfigvEm
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public zXJDVbuWPpRImHXsOZaiTTodHQoUshBWcDqITWFxPlMdWIKNRGOkcqYfigvEm()
        {
            
        }
        public zXJDVbuWPpRImHXsOZaiTTodHQoUshBWcDqITWFxPlMdWIKNRGOkcqYfigvEm(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public zXJDVbuWPpRImHXsOZaiTTodHQoUshBWcDqITWFxPlMdWIKNRGOkcqYfigvEm(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public zXJDVbuWPpRImHXsOZaiTTodHQoUshBWcDqITWFxPlMdWIKNRGOkcqYfigvEm GetzXJDVbuWPpRImHXsOZaiTTodHQoUshBWcDqITWFxPlMdWIKNRGOkcqYfigvEm(){
        var clasx = new zXJDVbuWPpRImHXsOZaiTTodHQoUshBWcDqITWFxPlMdWIKNRGOkcqYfigvEm();
        return  clasx;
    }

    public string RandomStringzXJDVbuWPpRImHXsOZaiTTodHQoUshBWcDqITWFxPlMdWIKNRGOkcqYfigvEm(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class xKgOcnzIGLkIxwMlckNJsaaskLxizxHjLNLupseWRJCTjwQgGO
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public xKgOcnzIGLkIxwMlckNJsaaskLxizxHjLNLupseWRJCTjwQgGO()
        {
            
        }
        public xKgOcnzIGLkIxwMlckNJsaaskLxizxHjLNLupseWRJCTjwQgGO(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xKgOcnzIGLkIxwMlckNJsaaskLxizxHjLNLupseWRJCTjwQgGO(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xKgOcnzIGLkIxwMlckNJsaaskLxizxHjLNLupseWRJCTjwQgGO GetxKgOcnzIGLkIxwMlckNJsaaskLxizxHjLNLupseWRJCTjwQgGO(){
        var clasx = new xKgOcnzIGLkIxwMlckNJsaaskLxizxHjLNLupseWRJCTjwQgGO();
        return  clasx;
    }

    public string RandomStringxKgOcnzIGLkIxwMlckNJsaaskLxizxHjLNLupseWRJCTjwQgGO(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class VwRscVbMNdLQuoslyOJSiPOfbAOHMk
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public VwRscVbMNdLQuoslyOJSiPOfbAOHMk()
        {
            
        }
        public VwRscVbMNdLQuoslyOJSiPOfbAOHMk(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public VwRscVbMNdLQuoslyOJSiPOfbAOHMk(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public VwRscVbMNdLQuoslyOJSiPOfbAOHMk GetVwRscVbMNdLQuoslyOJSiPOfbAOHMk(){
        var clasx = new VwRscVbMNdLQuoslyOJSiPOfbAOHMk();
        return  clasx;
    }

    public string RandomStringVwRscVbMNdLQuoslyOJSiPOfbAOHMk(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class YlDAvrbRixGTvEJEwAFNfWDhODgixaeRyLv
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public YlDAvrbRixGTvEJEwAFNfWDhODgixaeRyLv()
        {
            
        }
        public YlDAvrbRixGTvEJEwAFNfWDhODgixaeRyLv(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public YlDAvrbRixGTvEJEwAFNfWDhODgixaeRyLv(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public YlDAvrbRixGTvEJEwAFNfWDhODgixaeRyLv GetYlDAvrbRixGTvEJEwAFNfWDhODgixaeRyLv(){
        var clasx = new YlDAvrbRixGTvEJEwAFNfWDhODgixaeRyLv();
        return  clasx;
    }

    public string RandomStringYlDAvrbRixGTvEJEwAFNfWDhODgixaeRyLv(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class UplzHTDgPZjMhyghkFjVwjfHuHtOhFsBPGOfMerZoMe
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public UplzHTDgPZjMhyghkFjVwjfHuHtOhFsBPGOfMerZoMe()
        {
            
        }
        public UplzHTDgPZjMhyghkFjVwjfHuHtOhFsBPGOfMerZoMe(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public UplzHTDgPZjMhyghkFjVwjfHuHtOhFsBPGOfMerZoMe(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public UplzHTDgPZjMhyghkFjVwjfHuHtOhFsBPGOfMerZoMe GetUplzHTDgPZjMhyghkFjVwjfHuHtOhFsBPGOfMerZoMe(){
        var clasx = new UplzHTDgPZjMhyghkFjVwjfHuHtOhFsBPGOfMerZoMe();
        return  clasx;
    }

    public string RandomStringUplzHTDgPZjMhyghkFjVwjfHuHtOhFsBPGOfMerZoMe(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class HnhsuPJUBrqKYGGfjtjwotDCILCZpYRYpZuQETZLXFEVgQhcuDFilEwOjejjMkedaRVz
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public HnhsuPJUBrqKYGGfjtjwotDCILCZpYRYpZuQETZLXFEVgQhcuDFilEwOjejjMkedaRVz()
        {
            
        }
        public HnhsuPJUBrqKYGGfjtjwotDCILCZpYRYpZuQETZLXFEVgQhcuDFilEwOjejjMkedaRVz(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public HnhsuPJUBrqKYGGfjtjwotDCILCZpYRYpZuQETZLXFEVgQhcuDFilEwOjejjMkedaRVz(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public HnhsuPJUBrqKYGGfjtjwotDCILCZpYRYpZuQETZLXFEVgQhcuDFilEwOjejjMkedaRVz GetHnhsuPJUBrqKYGGfjtjwotDCILCZpYRYpZuQETZLXFEVgQhcuDFilEwOjejjMkedaRVz(){
        var clasx = new HnhsuPJUBrqKYGGfjtjwotDCILCZpYRYpZuQETZLXFEVgQhcuDFilEwOjejjMkedaRVz();
        return  clasx;
    }

    public string RandomStringHnhsuPJUBrqKYGGfjtjwotDCILCZpYRYpZuQETZLXFEVgQhcuDFilEwOjejjMkedaRVz(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class NQHwKpASbGMUiNyosdxodqnjvDRrQXUnifxq
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public NQHwKpASbGMUiNyosdxodqnjvDRrQXUnifxq()
        {
            
        }
        public NQHwKpASbGMUiNyosdxodqnjvDRrQXUnifxq(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public NQHwKpASbGMUiNyosdxodqnjvDRrQXUnifxq(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public NQHwKpASbGMUiNyosdxodqnjvDRrQXUnifxq GetNQHwKpASbGMUiNyosdxodqnjvDRrQXUnifxq(){
        var clasx = new NQHwKpASbGMUiNyosdxodqnjvDRrQXUnifxq();
        return  clasx;
    }

    public string RandomStringNQHwKpASbGMUiNyosdxodqnjvDRrQXUnifxq(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class MfeywrDUEZAYslunLFmqDVgiJzMahtAarzuMZLBhzsDlapgAmjdsUDhrzvowfdnKYZhs
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public MfeywrDUEZAYslunLFmqDVgiJzMahtAarzuMZLBhzsDlapgAmjdsUDhrzvowfdnKYZhs()
        {
            
        }
        public MfeywrDUEZAYslunLFmqDVgiJzMahtAarzuMZLBhzsDlapgAmjdsUDhrzvowfdnKYZhs(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public MfeywrDUEZAYslunLFmqDVgiJzMahtAarzuMZLBhzsDlapgAmjdsUDhrzvowfdnKYZhs(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public MfeywrDUEZAYslunLFmqDVgiJzMahtAarzuMZLBhzsDlapgAmjdsUDhrzvowfdnKYZhs GetMfeywrDUEZAYslunLFmqDVgiJzMahtAarzuMZLBhzsDlapgAmjdsUDhrzvowfdnKYZhs(){
        var clasx = new MfeywrDUEZAYslunLFmqDVgiJzMahtAarzuMZLBhzsDlapgAmjdsUDhrzvowfdnKYZhs();
        return  clasx;
    }

    public string RandomStringMfeywrDUEZAYslunLFmqDVgiJzMahtAarzuMZLBhzsDlapgAmjdsUDhrzvowfdnKYZhs(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class UTLJXanzzTgROWceIOfIVUVKJJsChcpiwDpNjX
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public UTLJXanzzTgROWceIOfIVUVKJJsChcpiwDpNjX()
        {
            
        }
        public UTLJXanzzTgROWceIOfIVUVKJJsChcpiwDpNjX(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public UTLJXanzzTgROWceIOfIVUVKJJsChcpiwDpNjX(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public UTLJXanzzTgROWceIOfIVUVKJJsChcpiwDpNjX GetUTLJXanzzTgROWceIOfIVUVKJJsChcpiwDpNjX(){
        var clasx = new UTLJXanzzTgROWceIOfIVUVKJJsChcpiwDpNjX();
        return  clasx;
    }

    public string RandomStringUTLJXanzzTgROWceIOfIVUVKJJsChcpiwDpNjX(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class OMXjWkqDBvQfRYtMuCEpcvzRZbYGjhxaQZBZtkkFGRqQGTwDVS
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public OMXjWkqDBvQfRYtMuCEpcvzRZbYGjhxaQZBZtkkFGRqQGTwDVS()
        {
            
        }
        public OMXjWkqDBvQfRYtMuCEpcvzRZbYGjhxaQZBZtkkFGRqQGTwDVS(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public OMXjWkqDBvQfRYtMuCEpcvzRZbYGjhxaQZBZtkkFGRqQGTwDVS(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public OMXjWkqDBvQfRYtMuCEpcvzRZbYGjhxaQZBZtkkFGRqQGTwDVS GetOMXjWkqDBvQfRYtMuCEpcvzRZbYGjhxaQZBZtkkFGRqQGTwDVS(){
        var clasx = new OMXjWkqDBvQfRYtMuCEpcvzRZbYGjhxaQZBZtkkFGRqQGTwDVS();
        return  clasx;
    }

    public string RandomStringOMXjWkqDBvQfRYtMuCEpcvzRZbYGjhxaQZBZtkkFGRqQGTwDVS(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class VNXrsKwzjDVVQxbDmVrYgiDhEJPVRrYdHCuvaLpSDQjcFhatCifsSsvnKqnjubisfsNNC
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public VNXrsKwzjDVVQxbDmVrYgiDhEJPVRrYdHCuvaLpSDQjcFhatCifsSsvnKqnjubisfsNNC()
        {
            
        }
        public VNXrsKwzjDVVQxbDmVrYgiDhEJPVRrYdHCuvaLpSDQjcFhatCifsSsvnKqnjubisfsNNC(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public VNXrsKwzjDVVQxbDmVrYgiDhEJPVRrYdHCuvaLpSDQjcFhatCifsSsvnKqnjubisfsNNC(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public VNXrsKwzjDVVQxbDmVrYgiDhEJPVRrYdHCuvaLpSDQjcFhatCifsSsvnKqnjubisfsNNC GetVNXrsKwzjDVVQxbDmVrYgiDhEJPVRrYdHCuvaLpSDQjcFhatCifsSsvnKqnjubisfsNNC(){
        var clasx = new VNXrsKwzjDVVQxbDmVrYgiDhEJPVRrYdHCuvaLpSDQjcFhatCifsSsvnKqnjubisfsNNC();
        return  clasx;
    }

    public string RandomStringVNXrsKwzjDVVQxbDmVrYgiDhEJPVRrYdHCuvaLpSDQjcFhatCifsSsvnKqnjubisfsNNC(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class pJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public pJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp()
        {
            
        }
        public pJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public pJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public pJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp GetpJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp(){
        var clasx = new pJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp();
        return  clasx;
    }

    public string RandomStringpJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class CcUHptTPOCoyzvyXLzkLEPdkLOMmxvu
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public CcUHptTPOCoyzvyXLzkLEPdkLOMmxvu()
        {
            
        }
        public CcUHptTPOCoyzvyXLzkLEPdkLOMmxvu(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public CcUHptTPOCoyzvyXLzkLEPdkLOMmxvu(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public CcUHptTPOCoyzvyXLzkLEPdkLOMmxvu GetCcUHptTPOCoyzvyXLzkLEPdkLOMmxvu(){
        var clasx = new CcUHptTPOCoyzvyXLzkLEPdkLOMmxvu();
        return  clasx;
    }

    public string RandomStringCcUHptTPOCoyzvyXLzkLEPdkLOMmxvu(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class OSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public OSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl()
        {
            
        }
        public OSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public OSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public OSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl GetOSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl(){
        var clasx = new OSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl();
        return  clasx;
    }

    public string RandomStringOSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public RugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA()
        {
            
        }
        public RugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA GetRugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA(){
        var clasx = new RugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA();
        return  clasx;
    }

    public string RandomStringRugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class nGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public nGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE()
        {
            
        }
        public nGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public nGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public nGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE GetnGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE(){
        var clasx = new nGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE();
        return  clasx;
    }

    public string RandomStringnGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class cScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public cScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt()
        {
            
        }
        public cScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public cScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public cScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt GetcScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt(){
        var clasx = new cScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt();
        return  clasx;
    }

    public string RandomStringcScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class mQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public mQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ()
        {
            
        }
        public mQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public mQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public mQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ GetmQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ(){
        var clasx = new mQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ();
        return  clasx;
    }

    public string RandomStringmQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class INmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public INmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW()
        {
            
        }
        public INmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public INmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public INmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW GetINmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW(){
        var clasx = new INmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW();
        return  clasx;
    }

    public string RandomStringINmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class xYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public xYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA()
        {
            
        }
        public xYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA GetxYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA(){
        var clasx = new xYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA();
        return  clasx;
    }

    public string RandomStringxYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class hWuyUjTivCttqaWSoYccdRLzzHoMDSK
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public hWuyUjTivCttqaWSoYccdRLzzHoMDSK()
        {
            
        }
        public hWuyUjTivCttqaWSoYccdRLzzHoMDSK(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public hWuyUjTivCttqaWSoYccdRLzzHoMDSK(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public hWuyUjTivCttqaWSoYccdRLzzHoMDSK GethWuyUjTivCttqaWSoYccdRLzzHoMDSK(){
        var clasx = new hWuyUjTivCttqaWSoYccdRLzzHoMDSK();
        return  clasx;
    }

    public string RandomStringhWuyUjTivCttqaWSoYccdRLzzHoMDSK(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class wTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public wTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly()
        {
            
        }
        public wTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public wTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public wTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly GetwTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly(){
        var clasx = new wTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly();
        return  clasx;
    }

    public string RandomStringwTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class xFFKoVzORkKQUUhHszJVQJYYvzVJhNR
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public xFFKoVzORkKQUUhHszJVQJYYvzVJhNR()
        {
            
        }
        public xFFKoVzORkKQUUhHszJVQJYYvzVJhNR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xFFKoVzORkKQUUhHszJVQJYYvzVJhNR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xFFKoVzORkKQUUhHszJVQJYYvzVJhNR GetxFFKoVzORkKQUUhHszJVQJYYvzVJhNR(){
        var clasx = new xFFKoVzORkKQUUhHszJVQJYYvzVJhNR();
        return  clasx;
    }

    public string RandomStringxFFKoVzORkKQUUhHszJVQJYYvzVJhNR(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RKsMotJouOmomvtSLkkxSLUNIDRhgtSurMBpjmsmxjYXhuKdEcSLdCPGpfDlbcH
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public RKsMotJouOmomvtSLkkxSLUNIDRhgtSurMBpjmsmxjYXhuKdEcSLdCPGpfDlbcH()
        {
            
        }
        public RKsMotJouOmomvtSLkkxSLUNIDRhgtSurMBpjmsmxjYXhuKdEcSLdCPGpfDlbcH(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RKsMotJouOmomvtSLkkxSLUNIDRhgtSurMBpjmsmxjYXhuKdEcSLdCPGpfDlbcH(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RKsMotJouOmomvtSLkkxSLUNIDRhgtSurMBpjmsmxjYXhuKdEcSLdCPGpfDlbcH GetRKsMotJouOmomvtSLkkxSLUNIDRhgtSurMBpjmsmxjYXhuKdEcSLdCPGpfDlbcH(){
        var clasx = new RKsMotJouOmomvtSLkkxSLUNIDRhgtSurMBpjmsmxjYXhuKdEcSLdCPGpfDlbcH();
        return  clasx;
    }

    public string RandomStringRKsMotJouOmomvtSLkkxSLUNIDRhgtSurMBpjmsmxjYXhuKdEcSLdCPGpfDlbcH(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class EzfHIWQFlSgQbaMWlZxzkkUviOLyCInpK
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public EzfHIWQFlSgQbaMWlZxzkkUviOLyCInpK()
        {
            
        }
        public EzfHIWQFlSgQbaMWlZxzkkUviOLyCInpK(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public EzfHIWQFlSgQbaMWlZxzkkUviOLyCInpK(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public EzfHIWQFlSgQbaMWlZxzkkUviOLyCInpK GetEzfHIWQFlSgQbaMWlZxzkkUviOLyCInpK(){
        var clasx = new EzfHIWQFlSgQbaMWlZxzkkUviOLyCInpK();
        return  clasx;
    }

    public string RandomStringEzfHIWQFlSgQbaMWlZxzkkUviOLyCInpK(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class bhaBbYRClUZmFHbSebnjKIsHVLDofzcTYZBNOdKhSrTTMwrdtFFi
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public bhaBbYRClUZmFHbSebnjKIsHVLDofzcTYZBNOdKhSrTTMwrdtFFi()
        {
            
        }
        public bhaBbYRClUZmFHbSebnjKIsHVLDofzcTYZBNOdKhSrTTMwrdtFFi(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public bhaBbYRClUZmFHbSebnjKIsHVLDofzcTYZBNOdKhSrTTMwrdtFFi(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public bhaBbYRClUZmFHbSebnjKIsHVLDofzcTYZBNOdKhSrTTMwrdtFFi GetbhaBbYRClUZmFHbSebnjKIsHVLDofzcTYZBNOdKhSrTTMwrdtFFi(){
        var clasx = new bhaBbYRClUZmFHbSebnjKIsHVLDofzcTYZBNOdKhSrTTMwrdtFFi();
        return  clasx;
    }

    public string RandomStringbhaBbYRClUZmFHbSebnjKIsHVLDofzcTYZBNOdKhSrTTMwrdtFFi(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class kyiHytvVffUTbWkluInZeeMGrcBzEGiLCg
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public kyiHytvVffUTbWkluInZeeMGrcBzEGiLCg()
        {
            
        }
        public kyiHytvVffUTbWkluInZeeMGrcBzEGiLCg(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public kyiHytvVffUTbWkluInZeeMGrcBzEGiLCg(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public kyiHytvVffUTbWkluInZeeMGrcBzEGiLCg GetkyiHytvVffUTbWkluInZeeMGrcBzEGiLCg(){
        var clasx = new kyiHytvVffUTbWkluInZeeMGrcBzEGiLCg();
        return  clasx;
    }

    public string RandomStringkyiHytvVffUTbWkluInZeeMGrcBzEGiLCg(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class xADYUqThwzBnSOnFEJlGjiRXmbOrtyjjXYtkHWUneoWkDEIPVLYiUbYPigltccoyPRP
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public xADYUqThwzBnSOnFEJlGjiRXmbOrtyjjXYtkHWUneoWkDEIPVLYiUbYPigltccoyPRP()
        {
            
        }
        public xADYUqThwzBnSOnFEJlGjiRXmbOrtyjjXYtkHWUneoWkDEIPVLYiUbYPigltccoyPRP(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xADYUqThwzBnSOnFEJlGjiRXmbOrtyjjXYtkHWUneoWkDEIPVLYiUbYPigltccoyPRP(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xADYUqThwzBnSOnFEJlGjiRXmbOrtyjjXYtkHWUneoWkDEIPVLYiUbYPigltccoyPRP GetxADYUqThwzBnSOnFEJlGjiRXmbOrtyjjXYtkHWUneoWkDEIPVLYiUbYPigltccoyPRP(){
        var clasx = new xADYUqThwzBnSOnFEJlGjiRXmbOrtyjjXYtkHWUneoWkDEIPVLYiUbYPigltccoyPRP();
        return  clasx;
    }

    public string RandomStringxADYUqThwzBnSOnFEJlGjiRXmbOrtyjjXYtkHWUneoWkDEIPVLYiUbYPigltccoyPRP(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class mahnqmRmADQiMxxZDIkWLASYXZrdfXoatsmpVDYqiyKwJFiXsMQAtNOmIJPRvoGdPqpT
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public mahnqmRmADQiMxxZDIkWLASYXZrdfXoatsmpVDYqiyKwJFiXsMQAtNOmIJPRvoGdPqpT()
        {
            
        }
        public mahnqmRmADQiMxxZDIkWLASYXZrdfXoatsmpVDYqiyKwJFiXsMQAtNOmIJPRvoGdPqpT(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public mahnqmRmADQiMxxZDIkWLASYXZrdfXoatsmpVDYqiyKwJFiXsMQAtNOmIJPRvoGdPqpT(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public mahnqmRmADQiMxxZDIkWLASYXZrdfXoatsmpVDYqiyKwJFiXsMQAtNOmIJPRvoGdPqpT GetmahnqmRmADQiMxxZDIkWLASYXZrdfXoatsmpVDYqiyKwJFiXsMQAtNOmIJPRvoGdPqpT(){
        var clasx = new mahnqmRmADQiMxxZDIkWLASYXZrdfXoatsmpVDYqiyKwJFiXsMQAtNOmIJPRvoGdPqpT();
        return  clasx;
    }

    public string RandomStringmahnqmRmADQiMxxZDIkWLASYXZrdfXoatsmpVDYqiyKwJFiXsMQAtNOmIJPRvoGdPqpT(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class KQtGaodZHeArmoxnCLFuEmUGMaOluFvGMJ
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public KQtGaodZHeArmoxnCLFuEmUGMaOluFvGMJ()
        {
            
        }
        public KQtGaodZHeArmoxnCLFuEmUGMaOluFvGMJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public KQtGaodZHeArmoxnCLFuEmUGMaOluFvGMJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public KQtGaodZHeArmoxnCLFuEmUGMaOluFvGMJ GetKQtGaodZHeArmoxnCLFuEmUGMaOluFvGMJ(){
        var clasx = new KQtGaodZHeArmoxnCLFuEmUGMaOluFvGMJ();
        return  clasx;
    }

    public string RandomStringKQtGaodZHeArmoxnCLFuEmUGMaOluFvGMJ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class GFOralBzeQMWTOmGZpJCqwUVulwwFfTtQyrRJFNIyaNOpMaQqDBVoGyJltxooFtyxSFVX
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public GFOralBzeQMWTOmGZpJCqwUVulwwFfTtQyrRJFNIyaNOpMaQqDBVoGyJltxooFtyxSFVX()
        {
            
        }
        public GFOralBzeQMWTOmGZpJCqwUVulwwFfTtQyrRJFNIyaNOpMaQqDBVoGyJltxooFtyxSFVX(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public GFOralBzeQMWTOmGZpJCqwUVulwwFfTtQyrRJFNIyaNOpMaQqDBVoGyJltxooFtyxSFVX(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public GFOralBzeQMWTOmGZpJCqwUVulwwFfTtQyrRJFNIyaNOpMaQqDBVoGyJltxooFtyxSFVX GetGFOralBzeQMWTOmGZpJCqwUVulwwFfTtQyrRJFNIyaNOpMaQqDBVoGyJltxooFtyxSFVX(){
        var clasx = new GFOralBzeQMWTOmGZpJCqwUVulwwFfTtQyrRJFNIyaNOpMaQqDBVoGyJltxooFtyxSFVX();
        return  clasx;
    }

    public string RandomStringGFOralBzeQMWTOmGZpJCqwUVulwwFfTtQyrRJFNIyaNOpMaQqDBVoGyJltxooFtyxSFVX(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class eQzHAdoKbQtnmDPXTXaFdAeXtRjnsIRjHbfBrMmQTaXjZyhGRVNxkmidmcOjtA
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public eQzHAdoKbQtnmDPXTXaFdAeXtRjnsIRjHbfBrMmQTaXjZyhGRVNxkmidmcOjtA()
        {
            
        }
        public eQzHAdoKbQtnmDPXTXaFdAeXtRjnsIRjHbfBrMmQTaXjZyhGRVNxkmidmcOjtA(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public eQzHAdoKbQtnmDPXTXaFdAeXtRjnsIRjHbfBrMmQTaXjZyhGRVNxkmidmcOjtA(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public eQzHAdoKbQtnmDPXTXaFdAeXtRjnsIRjHbfBrMmQTaXjZyhGRVNxkmidmcOjtA GeteQzHAdoKbQtnmDPXTXaFdAeXtRjnsIRjHbfBrMmQTaXjZyhGRVNxkmidmcOjtA(){
        var clasx = new eQzHAdoKbQtnmDPXTXaFdAeXtRjnsIRjHbfBrMmQTaXjZyhGRVNxkmidmcOjtA();
        return  clasx;
    }

    public string RandomStringeQzHAdoKbQtnmDPXTXaFdAeXtRjnsIRjHbfBrMmQTaXjZyhGRVNxkmidmcOjtA(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class PcwYftSRDVFJhBGCSSpBaWDiyNcRivqprcSWrSy
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public PcwYftSRDVFJhBGCSSpBaWDiyNcRivqprcSWrSy()
        {
            
        }
        public PcwYftSRDVFJhBGCSSpBaWDiyNcRivqprcSWrSy(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PcwYftSRDVFJhBGCSSpBaWDiyNcRivqprcSWrSy(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PcwYftSRDVFJhBGCSSpBaWDiyNcRivqprcSWrSy GetPcwYftSRDVFJhBGCSSpBaWDiyNcRivqprcSWrSy(){
        var clasx = new PcwYftSRDVFJhBGCSSpBaWDiyNcRivqprcSWrSy();
        return  clasx;
    }

    public string RandomStringPcwYftSRDVFJhBGCSSpBaWDiyNcRivqprcSWrSy(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class MdHwFRwKolqcAMltRJSRqkDzIEnqLiUSRWavGTFKucPvyxpdQramDqkcZInAeGyGR
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public MdHwFRwKolqcAMltRJSRqkDzIEnqLiUSRWavGTFKucPvyxpdQramDqkcZInAeGyGR()
        {
            
        }
        public MdHwFRwKolqcAMltRJSRqkDzIEnqLiUSRWavGTFKucPvyxpdQramDqkcZInAeGyGR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public MdHwFRwKolqcAMltRJSRqkDzIEnqLiUSRWavGTFKucPvyxpdQramDqkcZInAeGyGR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public MdHwFRwKolqcAMltRJSRqkDzIEnqLiUSRWavGTFKucPvyxpdQramDqkcZInAeGyGR GetMdHwFRwKolqcAMltRJSRqkDzIEnqLiUSRWavGTFKucPvyxpdQramDqkcZInAeGyGR(){
        var clasx = new MdHwFRwKolqcAMltRJSRqkDzIEnqLiUSRWavGTFKucPvyxpdQramDqkcZInAeGyGR();
        return  clasx;
    }

    public string RandomStringMdHwFRwKolqcAMltRJSRqkDzIEnqLiUSRWavGTFKucPvyxpdQramDqkcZInAeGyGR(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class qltrllUDuenBjcAUzGGFmlsSzOjEIZdvdbCvmhEsmSyGyDngDHsRvjKEtbsXC
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public qltrllUDuenBjcAUzGGFmlsSzOjEIZdvdbCvmhEsmSyGyDngDHsRvjKEtbsXC()
        {
            
        }
        public qltrllUDuenBjcAUzGGFmlsSzOjEIZdvdbCvmhEsmSyGyDngDHsRvjKEtbsXC(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public qltrllUDuenBjcAUzGGFmlsSzOjEIZdvdbCvmhEsmSyGyDngDHsRvjKEtbsXC(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public qltrllUDuenBjcAUzGGFmlsSzOjEIZdvdbCvmhEsmSyGyDngDHsRvjKEtbsXC GetqltrllUDuenBjcAUzGGFmlsSzOjEIZdvdbCvmhEsmSyGyDngDHsRvjKEtbsXC(){
        var clasx = new qltrllUDuenBjcAUzGGFmlsSzOjEIZdvdbCvmhEsmSyGyDngDHsRvjKEtbsXC();
        return  clasx;
    }

    public string RandomStringqltrllUDuenBjcAUzGGFmlsSzOjEIZdvdbCvmhEsmSyGyDngDHsRvjKEtbsXC(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class CSTsspZwahpKDwytYuMGZhDJIVIsKZpOrLUgYeGvMSTXbiMcbOxvCybUPKkXhgmAs
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public CSTsspZwahpKDwytYuMGZhDJIVIsKZpOrLUgYeGvMSTXbiMcbOxvCybUPKkXhgmAs()
        {
            
        }
        public CSTsspZwahpKDwytYuMGZhDJIVIsKZpOrLUgYeGvMSTXbiMcbOxvCybUPKkXhgmAs(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public CSTsspZwahpKDwytYuMGZhDJIVIsKZpOrLUgYeGvMSTXbiMcbOxvCybUPKkXhgmAs(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public CSTsspZwahpKDwytYuMGZhDJIVIsKZpOrLUgYeGvMSTXbiMcbOxvCybUPKkXhgmAs GetCSTsspZwahpKDwytYuMGZhDJIVIsKZpOrLUgYeGvMSTXbiMcbOxvCybUPKkXhgmAs(){
        var clasx = new CSTsspZwahpKDwytYuMGZhDJIVIsKZpOrLUgYeGvMSTXbiMcbOxvCybUPKkXhgmAs();
        return  clasx;
    }

    public string RandomStringCSTsspZwahpKDwytYuMGZhDJIVIsKZpOrLUgYeGvMSTXbiMcbOxvCybUPKkXhgmAs(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class QSQGkYdUOHTAnfessTNNSMEDEOuRfOrmIYr
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public QSQGkYdUOHTAnfessTNNSMEDEOuRfOrmIYr()
        {
            
        }
        public QSQGkYdUOHTAnfessTNNSMEDEOuRfOrmIYr(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public QSQGkYdUOHTAnfessTNNSMEDEOuRfOrmIYr(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public QSQGkYdUOHTAnfessTNNSMEDEOuRfOrmIYr GetQSQGkYdUOHTAnfessTNNSMEDEOuRfOrmIYr(){
        var clasx = new QSQGkYdUOHTAnfessTNNSMEDEOuRfOrmIYr();
        return  clasx;
    }

    public string RandomStringQSQGkYdUOHTAnfessTNNSMEDEOuRfOrmIYr(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class qXlIilGvJbOhQAukvuDCikzEhJJHDOgRKBkntQzOQsqixlirhiHOYbpFYha
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public qXlIilGvJbOhQAukvuDCikzEhJJHDOgRKBkntQzOQsqixlirhiHOYbpFYha()
        {
            
        }
        public qXlIilGvJbOhQAukvuDCikzEhJJHDOgRKBkntQzOQsqixlirhiHOYbpFYha(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public qXlIilGvJbOhQAukvuDCikzEhJJHDOgRKBkntQzOQsqixlirhiHOYbpFYha(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public qXlIilGvJbOhQAukvuDCikzEhJJHDOgRKBkntQzOQsqixlirhiHOYbpFYha GetqXlIilGvJbOhQAukvuDCikzEhJJHDOgRKBkntQzOQsqixlirhiHOYbpFYha(){
        var clasx = new qXlIilGvJbOhQAukvuDCikzEhJJHDOgRKBkntQzOQsqixlirhiHOYbpFYha();
        return  clasx;
    }

    public string RandomStringqXlIilGvJbOhQAukvuDCikzEhJJHDOgRKBkntQzOQsqixlirhiHOYbpFYha(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class cVeTcWGBqfOYAOYlvbpxxZBapvuaEchCgLuYcFFAQwY
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public cVeTcWGBqfOYAOYlvbpxxZBapvuaEchCgLuYcFFAQwY()
        {
            
        }
        public cVeTcWGBqfOYAOYlvbpxxZBapvuaEchCgLuYcFFAQwY(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public cVeTcWGBqfOYAOYlvbpxxZBapvuaEchCgLuYcFFAQwY(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public cVeTcWGBqfOYAOYlvbpxxZBapvuaEchCgLuYcFFAQwY GetcVeTcWGBqfOYAOYlvbpxxZBapvuaEchCgLuYcFFAQwY(){
        var clasx = new cVeTcWGBqfOYAOYlvbpxxZBapvuaEchCgLuYcFFAQwY();
        return  clasx;
    }

    public string RandomStringcVeTcWGBqfOYAOYlvbpxxZBapvuaEchCgLuYcFFAQwY(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class lTDzaEFNedxkCvFwctGXIhJNtuPAhpqQynCSwjqZEdaHDLmehheplTMEKqGfoEgomgm
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public lTDzaEFNedxkCvFwctGXIhJNtuPAhpqQynCSwjqZEdaHDLmehheplTMEKqGfoEgomgm()
        {
            
        }
        public lTDzaEFNedxkCvFwctGXIhJNtuPAhpqQynCSwjqZEdaHDLmehheplTMEKqGfoEgomgm(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public lTDzaEFNedxkCvFwctGXIhJNtuPAhpqQynCSwjqZEdaHDLmehheplTMEKqGfoEgomgm(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public lTDzaEFNedxkCvFwctGXIhJNtuPAhpqQynCSwjqZEdaHDLmehheplTMEKqGfoEgomgm GetlTDzaEFNedxkCvFwctGXIhJNtuPAhpqQynCSwjqZEdaHDLmehheplTMEKqGfoEgomgm(){
        var clasx = new lTDzaEFNedxkCvFwctGXIhJNtuPAhpqQynCSwjqZEdaHDLmehheplTMEKqGfoEgomgm();
        return  clasx;
    }

    public string RandomStringlTDzaEFNedxkCvFwctGXIhJNtuPAhpqQynCSwjqZEdaHDLmehheplTMEKqGfoEgomgm(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class LOrzSrnzTnNmSfasiBcXNgwlnxjupWxJe
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public LOrzSrnzTnNmSfasiBcXNgwlnxjupWxJe()
        {
            
        }
        public LOrzSrnzTnNmSfasiBcXNgwlnxjupWxJe(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public LOrzSrnzTnNmSfasiBcXNgwlnxjupWxJe(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public LOrzSrnzTnNmSfasiBcXNgwlnxjupWxJe GetLOrzSrnzTnNmSfasiBcXNgwlnxjupWxJe(){
        var clasx = new LOrzSrnzTnNmSfasiBcXNgwlnxjupWxJe();
        return  clasx;
    }

    public string RandomStringLOrzSrnzTnNmSfasiBcXNgwlnxjupWxJe(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class SPGKrSNUIMZcZLtbGFtECisCzrFqrhZpEljuZCRMeOG
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public SPGKrSNUIMZcZLtbGFtECisCzrFqrhZpEljuZCRMeOG()
        {
            
        }
        public SPGKrSNUIMZcZLtbGFtECisCzrFqrhZpEljuZCRMeOG(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public SPGKrSNUIMZcZLtbGFtECisCzrFqrhZpEljuZCRMeOG(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public SPGKrSNUIMZcZLtbGFtECisCzrFqrhZpEljuZCRMeOG GetSPGKrSNUIMZcZLtbGFtECisCzrFqrhZpEljuZCRMeOG(){
        var clasx = new SPGKrSNUIMZcZLtbGFtECisCzrFqrhZpEljuZCRMeOG();
        return  clasx;
    }

    public string RandomStringSPGKrSNUIMZcZLtbGFtECisCzrFqrhZpEljuZCRMeOG(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class rbhLZTZvaynGGWfdPRKrwMJdrztMdLTUEKWI
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public rbhLZTZvaynGGWfdPRKrwMJdrztMdLTUEKWI()
        {
            
        }
        public rbhLZTZvaynGGWfdPRKrwMJdrztMdLTUEKWI(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public rbhLZTZvaynGGWfdPRKrwMJdrztMdLTUEKWI(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public rbhLZTZvaynGGWfdPRKrwMJdrztMdLTUEKWI GetrbhLZTZvaynGGWfdPRKrwMJdrztMdLTUEKWI(){
        var clasx = new rbhLZTZvaynGGWfdPRKrwMJdrztMdLTUEKWI();
        return  clasx;
    }

    public string RandomStringrbhLZTZvaynGGWfdPRKrwMJdrztMdLTUEKWI(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class NRDuimJcHcOIofkzwNOehzTdVpxldwZGvTyXGayEiCsKVFmmRLJgkIQOxZYsoXzLDHMUh
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public NRDuimJcHcOIofkzwNOehzTdVpxldwZGvTyXGayEiCsKVFmmRLJgkIQOxZYsoXzLDHMUh()
        {
            
        }
        public NRDuimJcHcOIofkzwNOehzTdVpxldwZGvTyXGayEiCsKVFmmRLJgkIQOxZYsoXzLDHMUh(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public NRDuimJcHcOIofkzwNOehzTdVpxldwZGvTyXGayEiCsKVFmmRLJgkIQOxZYsoXzLDHMUh(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public NRDuimJcHcOIofkzwNOehzTdVpxldwZGvTyXGayEiCsKVFmmRLJgkIQOxZYsoXzLDHMUh GetNRDuimJcHcOIofkzwNOehzTdVpxldwZGvTyXGayEiCsKVFmmRLJgkIQOxZYsoXzLDHMUh(){
        var clasx = new NRDuimJcHcOIofkzwNOehzTdVpxldwZGvTyXGayEiCsKVFmmRLJgkIQOxZYsoXzLDHMUh();
        return  clasx;
    }

    public string RandomStringNRDuimJcHcOIofkzwNOehzTdVpxldwZGvTyXGayEiCsKVFmmRLJgkIQOxZYsoXzLDHMUh(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class WQdIwzdCHHPrIiSBWCTdtlCKSFGYDql
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public WQdIwzdCHHPrIiSBWCTdtlCKSFGYDql()
        {
            
        }
        public WQdIwzdCHHPrIiSBWCTdtlCKSFGYDql(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public WQdIwzdCHHPrIiSBWCTdtlCKSFGYDql(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public WQdIwzdCHHPrIiSBWCTdtlCKSFGYDql GetWQdIwzdCHHPrIiSBWCTdtlCKSFGYDql(){
        var clasx = new WQdIwzdCHHPrIiSBWCTdtlCKSFGYDql();
        return  clasx;
    }

    public string RandomStringWQdIwzdCHHPrIiSBWCTdtlCKSFGYDql(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class pMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public pMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl()
        {
            
        }
        public pMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public pMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public pMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl GetpMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl(){
        var clasx = new pMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl();
        return  clasx;
    }

    public string RandomStringpMGLWXuRBHmjJFEDxIdOGlHdOHbRQyjJQABLLsOcwNpBl(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class heKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public heKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt()
        {
            
        }
        public heKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public heKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public heKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt GetheKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt(){
        var clasx = new heKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt();
        return  clasx;
    }

    public string RandomStringheKrAPCNBhJiFzlYGHEWHGyskZILjMDgdt(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class XsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public XsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL()
        {
            
        }
        public XsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public XsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public XsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL GetXsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL(){
        var clasx = new XsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL();
        return  clasx;
    }

    public string RandomStringXsXXSFVRJCOOghiflVIIwgnZgAGlhviVNJweRsbskLqELHyfyoahZqL(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class PsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public PsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ()
        {
            
        }
        public PsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ GetPsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ(){
        var clasx = new PsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ();
        return  clasx;
    }

    public string RandomStringPsFzTaiquSVcUBWNuimCKdSqWTZSKxvLwDwFjfiwQ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class feVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public feVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp()
        {
            
        }
        public feVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public feVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public feVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp GetfeVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp(){
        var clasx = new feVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp();
        return  clasx;
    }

    public string RandomStringfeVommKaehQahLzrKLvBOhcdaFckDesECRRBrnmnNABtfruxLnaGDzTxBrOhKaWzp(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void Update()
        {
            if (!fixedTime && Application.isPlaying)
            {
                pSystem.Simulate(Time.unscaledDeltaTime, false, false, true);
                SetAllDirty();

                if ((currentMaterial != null && currentTexture != currentMaterial.mainTexture) ||
                    (material != null && currentMaterial != null && material.shader != currentMaterial.shader))
                {
                    pSystem = null;
                    Initialize();
                }
            }
        }

        private void LateUpdate()
        {
            if (!Application.isPlaying)
            {
                SetAllDirty();
            }
            else
            {
                if (fixedTime)
                {
                    pSystem.Simulate(Time.unscaledDeltaTime, false, false, true);
                    SetAllDirty();
                    if ((currentMaterial != null && currentTexture != currentMaterial.mainTexture) ||
                        (material != null && currentMaterial != null && material.shader != currentMaterial.shader))
                    {
                        pSystem = null;
                        Initialize();
                    }
                }
            }
            if (material == currentMaterial)
                return;
            pSystem = null;
            Initialize();
        }

        protected override void OnDestroy()
        {
            currentMaterial = null;
            currentTexture = null;
        }

        public void StartParticleEmission()
        {
            pSystem.Play();
        }

        public void StopParticleEmission()
        {
            pSystem.Stop(false, ParticleSystemStopBehavior.StopEmittingAndClear);
        }

        public void PauseParticleEmission()
        {
            pSystem.Stop(false, ParticleSystemStopBehavior.StopEmitting);
        }
    }
#endif
}