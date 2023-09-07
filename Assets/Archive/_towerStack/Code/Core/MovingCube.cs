using System;
using UnityEngine;

namespace _towerStack.Code.Core
{
    public class MovingCube : MonoBehaviour
    {
        public static event Action<bool> OnCubeStack;

        public static MovingCube CurrentCube { get; private set; }
        public static MovingCube LastCube { get; private set; }
        public static float _colorHVal { get; private set; }

        public MoveDirection MoveDirection { get; set; }

        [SerializeField] private float _moveSpeed = 8f;
        [SerializeField] private float _maxDistance = 8f;
        [SerializeField] private Renderer _base;
        [SerializeField] private SpriteRenderer _perfectVfx;
        [SerializeField] private Transform _fallingCubePrefab;

        int _inversDir = 1;

   
        public class huDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse
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

            public huDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse()
            {
            
            }
            public huDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse(string title, string publisher, string? isbn)
                => (Title, Publisher, Isbn) = (title, publisher, isbn);

            public huDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse(string title, string publisher)
                : this(title, publisher, null) {}

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }

        public huDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse GethuDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse(){
            var clasx = new huDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse();
            return  clasx;
        }

        public string RandomStringhuDKtsYvLxoFLyhKWSTbMfFhXBQnTGiUntktCUse(int length)
        {
            string chars = string.Empty;
            return chars;
        }
       
        public class QekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg
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

        public QekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg()
        {
            
        }
        public QekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public QekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public QekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg GetQekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg(){
        var clasx = new QekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg();
        return  clasx;
    }

    public string RandomStringQekWVopoCPZBjMfxAmXptZwWbqIQFgHOFapqFdJXPuLGbRKODhpg(int length)
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
 private void OnEnable()
        {
            CurrentCube = this;

            if (LastCube == null)
            {
                //LastCube = GameObject.FindWithTag("StartingCube").GetComponent<MovingCube>();
                LastCube = this;
                _colorHVal = UnityEngine.Random.Range(0f, 1f);
                if (_base) _base.material.color = Color.HSVToRGB(_colorHVal, .5f, 1f);

                return;
            }

            transform.localScale = LastCube.transform.localScale;

            GetComponent<Renderer>().material.color = GetRandomColor();
        }

        private void Update()
        {
            if (MoveDirection == MoveDirection.Z)
            {
                if (transform.position.z > _maxDistance || transform.position.z < -_maxDistance)
                    _inversDir *= -1;

                transform.position += transform.forward * Time.deltaTime * _moveSpeed * _inversDir;
            }

            else
            {
                if (transform.position.x > _maxDistance || transform.position.x < -_maxDistance)
                    _inversDir *= -1;

                transform.position += transform.right * Time.deltaTime * _moveSpeed * _inversDir;
            }

        }

        public void SetSpeed(float speed)
        {
            _moveSpeed = speed;
        }

        public bool Stop()
        {
            if (CurrentCube == LastCube) return false;

            _moveSpeed = 0;
            float hangover = GetHangover();
            bool isPerfect = false;

            if (Mathf.Abs(hangover) <= .2f)
            {
                transform.position = new Vector3(LastCube.transform.position.x, transform.position.y, LastCube.transform.position.z);

                TriggerPrefectVFX();

                isPerfect = true;
            }
            else
            {
                float max = MoveDirection == MoveDirection.Z ? LastCube.transform.localScale.z : LastCube.transform.localScale.x;
                if (Mathf.Abs(hangover) >= max)
                {
                    LastCube = null;
                    CurrentCube = null;
                    gameObject.AddComponent<Rigidbody>();
                    return true;

                    // GAME OVER
                }

                float direction = hangover > 0 ? 1f : -1f;

                if (MoveDirection == MoveDirection.Z)
                    SplitCubeOnZ(hangover, direction);
                else
                    SplitCubeOnX(hangover, direction);
            }

            LastCube = this;
            OnCubeStack?.Invoke(isPerfect);

            return false;
        }

        private void TriggerPrefectVFX()
        {
            SpriteRenderer vfx = Instantiate(_perfectVfx);
            vfx.transform.position = new Vector3(transform.position.x, transform.position.y - .5f, transform.position.z);
            vfx.transform.localScale = new Vector3(transform.localScale.x + .5f, transform.localScale.z + .5f, 1f);

            Color vfxColor = vfx.color;
            vfxColor.a = 0;
            LeanTween.color(vfx.gameObject, vfxColor, 1f).setOnComplete(() => { Destroy(vfx.gameObject); });

            //PerfectFX.Instance.TriggerPerfectText();
        }

        private float GetHangover()
        {
            if (MoveDirection == MoveDirection.Z)
                return transform.position.z - LastCube.transform.position.z;
            else
                return transform.position.x - LastCube.transform.position.x;
        }

        private void SplitCubeOnX(float hangover, float direction)
        {
            float newXSize = LastCube.transform.localScale.x - Mathf.Abs(hangover);
            float fallingBlockSize = transform.localScale.x - newXSize;

            float newXPosition = LastCube.transform.position.x + (hangover * .5f);
            transform.localScale = new Vector3(newXSize, transform.localScale.y, transform.localScale.z);
            transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);

            float cubeEdge = transform.position.x + (newXSize * .5f * direction);
            float fallingBlockXPosition = cubeEdge + (fallingBlockSize * .5f * direction);

            SpawnDropCube(fallingBlockXPosition, fallingBlockSize);
        }

        private void SplitCubeOnZ(float hangover, float direction)
        {
            float newZSize = LastCube.transform.localScale.z - Mathf.Abs(hangover);
            float fallingBlockSize = transform.localScale.z - newZSize;

            float newZPosition = LastCube.transform.position.z + (hangover * .5f);
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, newZSize);
            transform.position = new Vector3(transform.position.x, transform.position.y, newZPosition);

            float cubeEdge = transform.position.z + (newZSize * .5f * direction);
            float fallingBlockZPosition = cubeEdge + (fallingBlockSize * .5f * direction);

            SpawnDropCube(fallingBlockZPosition, fallingBlockSize);
        }

        private void SpawnDropCube(float fallingBlockPosition, float fallingBlockSize)
        {
            //var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Transform cube = Instantiate(_fallingCubePrefab, transform.parent);

            if (MoveDirection == MoveDirection.Z)
            {
                cube.localScale = new Vector3(transform.localScale.x, transform.localScale.y, fallingBlockSize);
                cube.position = new Vector3(transform.position.x, transform.position.y, fallingBlockPosition);
            }
            else
            {
                cube.localScale = new Vector3(fallingBlockSize, transform.localScale.y, transform.localScale.z);
                cube.position = new Vector3(fallingBlockPosition, transform.position.y, transform.position.z);
            }

            cube.GetComponent<Renderer>().material.color = GetComponent<Renderer>().material.color;

            //Destroy(cube.gameObject, 1f);
        }

        private Color GetRandomColor()
        {
            _colorHVal += .02f;
            _colorHVal = Mathf.Clamp(_colorHVal, 0, 1) >= 1 ? 0 : _colorHVal;
            return Color.HSVToRGB(_colorHVal, .5f, 1f);
        }
    }
}
