using System;

namespace SystemWrapper
{
    /// <summary>
    /// Wrapper for <see cref="System.Version"/> class.
    /// </summary>
    public class VersionWrap : IVersionWrap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.VersionWrap"/> class. 
        /// </summary>
        public VersionWrap(Version version)
        {
            VersionInstance = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.VersionWrap"/> class. 
        /// </summary>
        public VersionWrap()
        {
            VersionInstance = new Version();
        }

        /// <summary>
        /// Initializes a new instance of the Version class using the specified string.
        /// </summary>
        /// <param name="version">A string containing the major, minor, build, and revision numbers, where each number is delimited with a period character ('.').</param>
        public VersionWrap(string version)
        {
            VersionInstance = new Version(version);
        }

        /// <summary>
        /// Initializes a new instance of the Version class using the specified major and minor values. 
        /// </summary>
        /// <param name="major">The major version number.</param>
        /// <param name="minor">The minor version number.</param>
        public VersionWrap(int major, int minor)
        {
            VersionInstance = new Version(major, minor);
        }

        /// <summary>
        /// Initializes a new instance of the Version class using the specified major and minor values. 
        /// </summary>
        /// <param name="major">The major version number.</param>
        /// <param name="minor">The minor version number.</param>
        /// <param name="build">The build number.</param>
        public VersionWrap(int major, int minor, int build)
        {
            VersionInstance = new Version(major, minor, build);
        }

        /// <summary>
        /// Initializes a new instance of the Version class using the specified major and minor values. 
        /// </summary>
        /// <param name="major">The major version number.</param>
        /// <param name="minor">The minor version number.</param>
        /// <param name="build">The build number.</param>
        /// <param name="revision">The revision number.</param>
        public VersionWrap(int major, int minor, int build, int revision)
        {
            VersionInstance = new Version(major, minor, build, revision);
        }

        public Version VersionInstance { get; private set; }

        public int Build
        {
            get { return VersionInstance.Build; }
        }

        public int Major
        {
            get { return VersionInstance.Major; }
        }

        public short MajorRevision
        {
            get { return VersionInstance.MajorRevision; }
        }

        public int Minor
        {
            get { return VersionInstance.Minor; }
        }

        public short MinorRevision
        {
            get { return VersionInstance.MinorRevision; }
        }

        public int Revision
        {
            get { return VersionInstance.Revision; }
        }

        public object Clone()
        {
            return VersionInstance.Clone();
        }

        public int CompareTo(object version)
        {
            return VersionInstance.CompareTo(version);
        }

        public int CompareTo(IVersionWrap value)
        {
            return VersionInstance.CompareTo(value.VersionInstance);
        }

        public override bool Equals(object obj)
        {
            return VersionInstance.Equals(obj);
        }

        public bool Equals(IVersionWrap obj)
        {
            return VersionInstance.Equals(obj.VersionInstance);
        }

        public override int GetHashCode()
        {
            return VersionInstance.GetHashCode();
        }

        public override string ToString()
        {
            return VersionInstance.ToString();
        }

        public string ToString(int fieldCount)
        {
            return VersionInstance.ToString(fieldCount);
        }
    }
}