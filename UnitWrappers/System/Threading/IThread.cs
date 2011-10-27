using System.Globalization;
using System.Threading;
using System.Runtime.Remoting.Contexts;

namespace UnitWrappers.System.Threading
{
    /// <summary>
    /// Wrapper for <see cref="Thread"/> class.
    /// </summary>
    public interface IThread
    {
        /// <summary>
        /// Gets or sets the culture for the current thread.
        /// </summary>
        /// <value>
        /// A CultureInfo representing the culture for the current thread.
        /// </value>
        CultureInfo CurrentCulture { get; set; }

        /// <summary>
        /// Gets a unique identifier for the current managed thread.
        /// </summary>
        /// <value>
        /// An integer that represents a unique identifier for this managed thread.
        /// </value>
        int ManagedThreadId { get; }

        CultureInfo CurrentUICulture { get; set; }

#if !PORTABLE

        /// <summary>
        /// Gets a value indicating the execution status of the current thread.
        /// </summary>
        /// <value>
        /// true if this thread has been started and has not terminated normally or aborted; otherwise, false.
        /// </value>
        bool IsAlive { get; }



        /// <summary>
        /// Gets a value indicating whether or not a thread belongs to the managed thread pool.
        /// </summary>
        /// <value>
        /// true if this thread belongs to the managed thread pool; otherwise, false.
        /// </value>
        bool IsThreadPoolThread { get; }

        /// <summary>
        /// Gets a value containing the states of the current thread.
        /// </summary>
        /// <value>
        /// One of the <see cref="global::System.Threading.ThreadState"/> values indicating the state of the current thread. The initial value is Unstarted.
        /// </value>
        ThreadState ThreadState { get; }

        /// <summary>
        /// Gets or sets a value indicating whether or not a thread is a background thread.
        /// </summary>
        /// <value>
        /// true if this thread is or is to become a background thread; otherwise, false.
        /// </value>
        bool IsBackground { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the scheduling priority of a thread.
        /// </summary>
        /// <value>
        /// One of the <see cref="ThreadPriority"/> values. The default value is Normal.
        /// </value>
        ThreadPriority Priority { get; set; }

         void Abort();
        void SetApartmentState(ApartmentState state);
         void Start();
        void Start(object parameter);
         void Join();
#endif
        /*
                // Methods
            public Thread(ParameterizedThreadStart start);
            public Thread(ThreadStart start);
            public Thread(ParameterizedThreadStart start, int maxStackSize);
            public Thread(ThreadStart start, int maxStackSize);

            [SecurityPermission(SecurityAction.Demand, ControlThread=true)]
            public void Abort(object stateInfo);
            [HostProtection(SecurityAction.LinkDemand, SharedState=true, ExternalThreading=true)]
            public static LocalDataStoreSlot AllocateDataSlot();
            [HostProtection(SecurityAction.LinkDemand, SharedState=true, ExternalThreading=true)]
            public static LocalDataStoreSlot AllocateNamedDataSlot(string name);
            [MethodImpl(MethodImplOptions.InternalCall), ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail), HostProtection(SecurityAction.LinkDemand, Synchronization=true, ExternalThreading=true)]
            public static extern void BeginCriticalRegion();
            [MethodImpl(MethodImplOptions.InternalCall), ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail), SecurityPermission(SecurityAction.LinkDemand, ControlThread=true)]
            public static extern void BeginThreadAffinity();
            [MethodImpl(MethodImplOptions.InternalCall), ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success), HostProtection(SecurityAction.LinkDemand, Synchronization=true, ExternalThreading=true)]
            public static extern void EndCriticalRegion();
            [MethodImpl(MethodImplOptions.InternalCall), ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail), SecurityPermission(SecurityAction.LinkDemand, ControlThread=true)]
            public static extern void EndThreadAffinity();
            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override void Finalize();
            [HostProtection(SecurityAction.LinkDemand, SharedState=true, ExternalThreading=true)]
            public static void FreeNamedDataSlot(string name);
            public ApartmentState GetApartmentState();
            [HostProtection(SecurityAction.LinkDemand, SharedState=true, ExternalThreading=true)]
            public static object GetData(LocalDataStoreSlot slot);
            public static AppDomain GetDomain();
            public static int GetDomainID();
            [MethodImpl(MethodImplOptions.InternalCall), ComVisible(false)]
            public override extern int GetHashCode();
            [HostProtection(SecurityAction.LinkDemand, SharedState=true, ExternalThreading=true)]
            public static LocalDataStoreSlot GetNamedDataSlot(string name);
            [SecurityPermission(SecurityAction.Demand, ControlThread=true)]
            public void Interrupt();

            [HostProtection(SecurityAction.LinkDemand, Synchronization=true, ExternalThreading=true)]
            public bool Join(int millisecondsTimeout);
            [HostProtection(SecurityAction.LinkDemand, Synchronization=true, ExternalThreading=true)]
            public bool Join(TimeSpan timeout);
            [MethodImpl(MethodImplOptions.InternalCall)]
            public static extern void MemoryBarrier();
            [SecurityPermission(SecurityAction.Demand, ControlThread=true)]
            public static void ResetAbort();
            
            [HostProtection(SecurityAction.LinkDemand, SharedState=true, ExternalThreading=true)]
            public static void SetData(LocalDataStoreSlot slot, object data);
            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success), HostProtection(SecurityAction.LinkDemand, Synchronization=true, ExternalThreading=true)]
            public static void SpinWait(int iterations);

            [HostProtection(SecurityAction.LinkDemand, Synchronization=true, SelfAffectingThreading=true)]
            public bool TrySetApartmentState(ApartmentState state);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static byte VolatileRead(ref byte address);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static double VolatileRead(ref double address);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static short VolatileRead(ref short address);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static int VolatileRead(ref int address);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static long VolatileRead(ref long address);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static IntPtr VolatileRead(ref IntPtr address);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static object VolatileRead(ref object address);
            [MethodImpl(MethodImplOptions.NoInlining), CLSCompliant(false)]
            public static sbyte VolatileRead(ref sbyte address);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static float VolatileRead(ref float address);
            [MethodImpl(MethodImplOptions.NoInlining), CLSCompliant(false)]
            public static ushort VolatileRead(ref ushort address);
            [MethodImpl(MethodImplOptions.NoInlining), CLSCompliant(false)]
            public static uint VolatileRead(ref uint address);
            [MethodImpl(MethodImplOptions.NoInlining), CLSCompliant(false)]
            public static ulong VolatileRead(ref ulong address);
            [MethodImpl(MethodImplOptions.NoInlining), CLSCompliant(false)]
            public static UIntPtr VolatileRead(ref UIntPtr address);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void VolatileWrite(ref byte address, byte value);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void VolatileWrite(ref double address, double value);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void VolatileWrite(ref short address, short value);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void VolatileWrite(ref int address, int value);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void VolatileWrite(ref long address, long value);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void VolatileWrite(ref IntPtr address, IntPtr value);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void VolatileWrite(ref object address, object value);
            [MethodImpl(MethodImplOptions.NoInlining), CLSCompliant(false)]
            public static void VolatileWrite(ref sbyte address, sbyte value);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static void VolatileWrite(ref float address, float value);
            [MethodImpl(MethodImplOptions.NoInlining), CLSCompliant(false)]
            public static void VolatileWrite(ref ushort address, ushort value);
            [MethodImpl(MethodImplOptions.NoInlining), CLSCompliant(false)]
            public static void VolatileWrite(ref uint address, uint value);
            [MethodImpl(MethodImplOptions.NoInlining), CLSCompliant(false)]
            public static void VolatileWrite(ref ulong address, ulong value);
            [MethodImpl(MethodImplOptions.NoInlining), CLSCompliant(false)]
            public static void VolatileWrite(ref UIntPtr address, UIntPtr value);

            // Properties
            public static IPrincipal CurrentPrincipal { get; [SecurityPermission(SecurityAction.Demand, Flags=SecurityPermissionFlag.ControlPrincipal)] set; }
            public CultureInfo CurrentUICulture { get; [HostProtection(SecurityAction.LinkDemand, ExternalThreading=true)] set; }
            public ExecutionContext ExecutionContext { [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)] get; }
            public string Name { get; [HostProtection(SecurityAction.LinkDemand, ExternalThreading=true)] set; }
        */
    }

}