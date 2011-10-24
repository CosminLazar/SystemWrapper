using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace UnitWrappers.System.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.StreamWriter"/> class.
    /// </summary>
    [Serializable]
    [ComVisible(true)]
    public class StreamWriterWrap : TextWriter, IStreamWriter
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.StreamWriterWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="streamWriter">A <see cref="T:System.IO.StreamWriter"/> object.</param>
        public StreamWriterWrap(StreamWriter streamWriter)
        {
            StreamWriterInstance = streamWriter;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.StreamWriterWrap"/> class for the specified stream, using UTF-8 encoding and the default buffer size.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        public StreamWriterWrap(Stream stream)
        {
            StreamWriterInstance = new StreamWriter(stream);
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.StreamWriterWrap"/> class for the specified stream, using UTF-8 encoding and the default buffer size.
        /// </summary>
        /// <param name="path">The complete file path to write to. path can be a file name.</param>
        public StreamWriterWrap(string path)
        {
            StreamWriterInstance = new StreamWriter(path);
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.StreamWriterWrap"/> class for the specified stream, using the specified encoding and the default buffer size. 
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="encoding">The character encoding to use.</param>
        public StreamWriterWrap(Stream stream, Encoding encoding)
        {
            StreamWriterInstance = new StreamWriter(stream, encoding);
        }


        /// <summary>
        /// Initializes a new instance of the StreamWriter class for the specified file on the specified path, using the default encoding and buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.
        /// </summary>
        /// <param name="path">The complete file path to write to.</param>
        /// <param name="append">Determines whether data is to be appended to the file. If the file exists and append is false, the file is overwritten. If the file exists and append is true, the data is appended to the file. Otherwise, a new file is created.</param>
        public StreamWriterWrap(string path, bool append)
        {
            StreamWriterInstance = new StreamWriter(path, append);
        }


        /// <summary>
        /// Initializes a new instance of the StreamWriter class for the specified stream, using the specified encoding and buffer size. 
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <param name="bufferSize">Sets the buffer size.</param>
        public StreamWriterWrap(Stream stream, Encoding encoding, int bufferSize)
        {
            StreamWriterInstance = new StreamWriter(stream, encoding, bufferSize);
        }



        /// <summary>
        /// Initializes a new instance of the StreamWriter class for the specified file on the specified path, using the specified encoding and default buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.
        /// </summary>
        /// <param name="path">The complete file path to write to.</param>
        /// <param name="append">Determines whether data is to be appended to the file. If the file exists and append is false, the file is overwritten. If the file exists and append is true, the data is appended to the file. Otherwise, a new file is created.</param>
        /// <param name="encoding">The character encoding to use.</param>
        public StreamWriterWrap(string path, bool append, Encoding encoding)
        {
            StreamWriterInstance = new StreamWriter(path, append, encoding);
        }



        /// <summary>
        /// Initializes a new instance of the StreamWriter class for the specified file on the specified path, using the specified encoding and buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.
        /// </summary>
        /// <param name="path">The complete file path to write to.</param>
        /// <param name="append">Determines whether data is to be appended to the file. If the file exists and append is false, the file is overwritten. If the file exists and append is true, the data is appended to the file. Otherwise, a new file is created.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <param name="bufferSize">Sets the buffer size.</param>
        public StreamWriterWrap(string path, bool append, Encoding encoding, int bufferSize)
        {
            StreamWriterInstance = new StreamWriter(path, append, encoding, bufferSize);
        }



        public bool AutoFlush
        {
            get { return StreamWriterInstance.AutoFlush; }
            set { StreamWriterInstance.AutoFlush = value; }
        }

        public Stream BaseStream
        {
            get { return StreamWriterInstance.BaseStream; }
        }

        public override Encoding Encoding
        {
            get { return StreamWriterInstance.Encoding; }
        }

        public StreamWriter StreamWriterInstance { get; private set; }

        public override void Close()
        {
            StreamWriterInstance.Close();
        }

        public override void Flush()
        {
            StreamWriterInstance.Flush();
        }

        public override void Write(char value)
        {
            StreamWriterInstance.Write(value);
        }

        public override void Write(char[] buffer)
        {
            StreamWriterInstance.Write(buffer);
        }

        public override void Write(string value)
        {
            StreamWriterInstance.Write(value);
        }

        public override void Write(char[] buffer, int index, int count)
        {
            StreamWriterInstance.Write(buffer, index, count);
        }
    }
}