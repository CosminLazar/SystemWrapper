using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace UnitWrappers.System.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.MemoryStream"/> class.
    /// </summary>
    public class MemoryStreamWrap : IMemoryStream
	{

		/// <summary>
		/// Initializes a new instance of the MemoryStreamWrap class with an expandable capacity initialized to zero. 
		/// </summary>
		public MemoryStreamWrap()
		{
         MemoryStreamInstance = new MemoryStream();
		}


		/// <summary>
		/// Initializes a new instance of the MemoryStreamWrap class with an expandable capacity initialized to zero. 
		/// </summary>
		public MemoryStreamWrap(Stream stream)
		{
			MemoryStreamInstance = stream as MemoryStream;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnitWrappers.System.IO.MemoryStreamWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="memoryStream">A <see cref="T:System.IO.MemoryStream"/> object.</param>
		public MemoryStreamWrap(MemoryStream memoryStream)
		{
			MemoryStreamInstance = memoryStream;
		}

		/// <summary>
		/// Initializes a new non-resizable instance of the MemoryStreamWrap class based on the specified byte array. 
		/// </summary>
		/// <param name="buffer">The array of unsigned bytes from which to create the current stream. </param>
		public MemoryStreamWrap(byte[] buffer)
		{
			MemoryStreamInstance = new MemoryStream(buffer);
		}


		/// <summary>
		/// Initializes a new instance of the MemoryStreamWrap class with an expandable capacity initialized as specified. 
		/// </summary>
		/// <param name="capacity"></param>
		public MemoryStreamWrap(int capacity)
		{
	MemoryStreamInstance = new MemoryStream(capacity);
		}


		/// <summary>
		/// Initializes a new non-resizable instance of the MemoryStreamWrap class based on the specified byte array with the CanWrite property set as specified. 
		/// </summary>
		/// <param name="buffer">The array of unsigned bytes from which to create this stream. </param>
		/// <param name="writable">The setting of the CanWrite property, which determines whether the stream supports writing. </param>
		public MemoryStreamWrap(byte[] buffer, bool writable)
		{
			MemoryStreamInstance = new MemoryStream(buffer, writable);
		}



		/// <summary>
		/// Initializes a new non-resizable instance of the MemoryStreamWrap class based on the specified region (index) of a byte array. 
		/// </summary>
		/// <param name="buffer">The array of unsigned bytes from which to create this stream. </param>
		/// <param name="index">The index into buffer at which the stream begins.</param>
		/// <param name="count">The length of the stream in bytes. </param>
		public MemoryStreamWrap(byte[] buffer, int index, int count)
		{
			MemoryStreamInstance = new MemoryStream(buffer, index, count);
		}



		/// <summary>
		/// Initializes a new non-resizable instance of the MemoryStreamWrap class based on the specified region of a byte array, with the CanWrite property set as specified. 
		/// </summary>
		/// <param name="buffer">The array of unsigned bytes from which to create this stream. </param>
		/// <param name="index">The index into buffer at which the stream begins.</param>
		/// <param name="count">The length of the stream in bytes. </param>
		/// <param name="writable">The setting of the CanWrite property, which determines whether the stream supports writing. </param>
		public MemoryStreamWrap(byte[] buffer, int index, int count, bool writable)
		{
			MemoryStreamInstance = new MemoryStream(buffer, index, count, writable);
		}


		/// <summary>
		/// Initializes a new instance of the MemoryStreamWrap class based on the specified region of a byte array, with the CanWrite property set as specified, and the ability to call GetBuffer set as specified. 
		/// </summary>
		/// <param name="buffer">The array of unsigned bytes from which to create this stream. </param>
		/// <param name="index">The index into buffer at which the stream begins.</param>
		/// <param name="count">The length of the stream in bytes.</param>
		/// <param name="writable">The setting of the CanWrite property, which determines whether the stream supports writing. </param>
		/// <param name="publiclyVisible"> true to enable GetBuffer, which returns the unsigned byte array from which the stream was created; otherwise, false. </param>
		public MemoryStreamWrap(byte[] buffer, int index, int count, bool writable, bool publiclyVisible)
		{
			MemoryStreamInstance = new MemoryStream(buffer, index, count, writable, publiclyVisible);
		}
		
		/// <summary>
		/// Gets a value indicating whether the current stream supports reading.
        /// </summary>
        public bool CanRead
        {
            get { return MemoryStreamInstance.CanRead; }
        }

        /// <summary>
        /// Gets a value indicating whether the current stream supports seeking.
        /// </summary>
        public bool CanSeek
        {
            get { return MemoryStreamInstance.CanSeek; }
        }

        [ComVisible(false)]
        public bool CanTimeout
        {
            get { return MemoryStreamInstance.CanTimeout; }
        }

        /// <summary>
        /// Gets a value indicating whether the current stream supports writing. 
        /// </summary>
        public bool CanWrite
        {
            get { return MemoryStreamInstance.CanWrite; }
        }

        public int Capacity
        {
            get { return MemoryStreamInstance.Capacity; }
            set { MemoryStreamInstance.Capacity = value; }
        }

        /// <summary>
        /// Gets the length of the stream in bytes.
        /// </summary>
        public long Length
        {
            get { return MemoryStreamInstance.Length; }
        }

        public MemoryStream MemoryStreamInstance { get; private set; }

        /// <summary>
        /// Gets or sets the current position within the stream. 
        /// </summary>
        public long Position
        {
            get { return MemoryStreamInstance.Position; }
            set { MemoryStreamInstance.Position = value; }
        }

        [ComVisible(false)]
        public int ReadTimeout
        {
            get { return MemoryStreamInstance.ReadTimeout; }
            set { MemoryStreamInstance.ReadTimeout = value; }
        }

        public Stream StreamInstance { get { return MemoryStreamInstance; } }

        [ComVisible(false)]
        public int WriteTimeout
        {
            get { return MemoryStreamInstance.WriteTimeout; }
            set { MemoryStreamInstance.WriteTimeout = value; }
        }

        [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        public IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            return MemoryStreamInstance.BeginRead(buffer, offset, count, callback, state);
        }

        [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        public IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            return MemoryStreamInstance.BeginWrite(buffer, offset, count, callback, state);
        }

        public virtual void Close()
        {
            MemoryStreamInstance.Close();
        }

        public int EndRead(IAsyncResult asyncResult)
        {
            return MemoryStreamInstance.EndRead(asyncResult);
        }

        public void EndWrite(IAsyncResult asyncResult)
        {
            MemoryStreamInstance.EndWrite(asyncResult);
        }

        /// <summary>
        /// Overrides Stream.Flush so that no action is performed. 
        /// </summary>
        public void Flush()
        {
            MemoryStreamInstance.Flush();
        }

        /// <summary>
        /// Reads a block of bytes from the current stream and writes the data to buffer. 
        /// </summary>
        /// <param name="buffer">When this method returns, contains the specified byte array with the values between offset and (offset + count - 1) replaced by the characters read from the current stream. </param>
        /// <param name="offset">The byte offset in buffer at which to begin reading.</param>
        /// <param name="count">The maximum number of bytes to read. </param>
        /// <returns>The total number of bytes written into the buffer. This can be less than the number of bytes requested if that number of bytes are not currently available, or zero if the end of the stream is reached before any bytes are read. </returns>
        public int Read(byte[] buffer, int offset, int count)
        {
            return MemoryStreamInstance.Read(buffer, offset, count);
        }

        /// <summary>
        /// Reads a byte from the current stream. 
        /// </summary>
        /// <returns>The byte cast to a Int32, or -1 if the end of the stream has been reached.</returns>
        public int ReadByte()
        {
            return MemoryStreamInstance.ReadByte();
        }

        /// <summary>
        /// Sets the position within the current stream to the specified value. 
        /// </summary>
        /// <param name="offset">The new position within the stream. This is relative to the loc parameter, and can be positive or negative. </param>
        /// <param name="origin">A value of type SeekOrigin, which acts as the seek reference point. </param>
        /// <returns>The new position within the stream, calculated by combining the initial reference point and the offset.</returns>
        public long Seek(long offset, SeekOrigin origin)
        {
            return MemoryStreamInstance.Seek(offset, origin);
        }

        /// <summary>
        /// Sets the length of the current stream to the specified value. 
        /// </summary>
        /// <param name="value">The value at which to set the length.</param>
        public void SetLength(long value)
        {
            MemoryStreamInstance.SetLength(value);
        }

        [HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
        public IStream Synchronized(IStream stream)
        {
            return new MemoryStreamWrap(Stream.Synchronized(stream.StreamInstance));
        }

        /// <summary>
        /// Writes a block of bytes to the current stream using data read from buffer. 
        /// </summary>
        /// <param name="buffer">The buffer to write data from. </param>
        /// <param name="offset">The byte offset in buffer at which to begin writing from. </param>
        /// <param name="count">The maximum number of bytes to write. </param>
        public void Write(byte[] buffer, int offset, int count)
        {
            MemoryStreamInstance.Write(buffer, offset, count);
        }

        /// <summary>
        /// Writes a byte to the current stream at the current position. 
        /// </summary>
        /// <param name="value">The byte to write. </param>
        public void WriteByte(byte value)
        {
            MemoryStreamInstance.WriteByte(value);
        }

        public byte[] GetBuffer()
        {
            return MemoryStreamInstance.GetBuffer();
        }

        public byte[] ToArray()
        {
            return MemoryStreamInstance.ToArray();
        }

        public void WriteTo(IStream stream)
        {
            MemoryStreamInstance.WriteTo(stream.StreamInstance);
        }

        public void Dispose()
        {
            MemoryStreamInstance.Dispose();
        }
    }
}
