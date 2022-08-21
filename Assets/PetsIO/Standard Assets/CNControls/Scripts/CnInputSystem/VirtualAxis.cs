namespace PetsIO.Standard_Assets.CNControls.Scripts.CnInputSystem
{
    /// <summary>
    /// Virtual axis class
    /// </summary>
    public class VirtualAxis
    {
        /// <summary>
        /// Name of the axis for which this virtual axis has to be registered
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Curret value of the axis
        /// </summary>
        public float Value { get; set; }

        public VirtualAxis(string name)
        {
            Name = name;
        }
    }
}