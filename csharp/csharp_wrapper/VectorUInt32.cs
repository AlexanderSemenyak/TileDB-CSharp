//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TileDB {

public class VectorUInt32 : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<uint>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VectorUInt32(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VectorUInt32 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VectorUInt32() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tiledbcsPINVOKE.delete_VectorUInt32(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public VectorUInt32(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (uint element in c) {
      this.Add(element);
    }
  }

  public VectorUInt32(global::System.Collections.Generic.IEnumerable<uint> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (uint element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public uint this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(uint[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(uint[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, uint[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public uint[] ToArray() {
    uint[] array = new uint[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<uint> global::System.Collections.Generic.IEnumerable<uint>.GetEnumerator() {
    return new VectorUInt32Enumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new VectorUInt32Enumerator(this);
  }

  public VectorUInt32Enumerator GetEnumerator() {
    return new VectorUInt32Enumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class VectorUInt32Enumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<uint>
  {
    private VectorUInt32 collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public VectorUInt32Enumerator(VectorUInt32 collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public uint Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (uint)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    tiledbcsPINVOKE.VectorUInt32_Clear(swigCPtr);
  }

  public void Add(uint x) {
    tiledbcsPINVOKE.VectorUInt32_Add(swigCPtr, x);
  }

  private uint size() {
    uint ret = tiledbcsPINVOKE.VectorUInt32_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = tiledbcsPINVOKE.VectorUInt32_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    tiledbcsPINVOKE.VectorUInt32_reserve(swigCPtr, n);
  }

  public VectorUInt32() : this(tiledbcsPINVOKE.new_VectorUInt32__SWIG_0(), true) {
  }

  public VectorUInt32(VectorUInt32 other) : this(tiledbcsPINVOKE.new_VectorUInt32__SWIG_1(VectorUInt32.getCPtr(other)), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorUInt32(int capacity) : this(tiledbcsPINVOKE.new_VectorUInt32__SWIG_2(capacity), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint getitemcopy(int index) {
    uint ret = tiledbcsPINVOKE.VectorUInt32_getitemcopy(swigCPtr, index);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint getitem(int index) {
    uint ret = tiledbcsPINVOKE.VectorUInt32_getitem(swigCPtr, index);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, uint val) {
    tiledbcsPINVOKE.VectorUInt32_setitem(swigCPtr, index, val);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(VectorUInt32 values) {
    tiledbcsPINVOKE.VectorUInt32_AddRange(swigCPtr, VectorUInt32.getCPtr(values));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorUInt32 GetRange(int index, int count) {
    global::System.IntPtr cPtr = tiledbcsPINVOKE.VectorUInt32_GetRange(swigCPtr, index, count);
    VectorUInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorUInt32(cPtr, true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, uint x) {
    tiledbcsPINVOKE.VectorUInt32_Insert(swigCPtr, index, x);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, VectorUInt32 values) {
    tiledbcsPINVOKE.VectorUInt32_InsertRange(swigCPtr, index, VectorUInt32.getCPtr(values));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    tiledbcsPINVOKE.VectorUInt32_RemoveAt(swigCPtr, index);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    tiledbcsPINVOKE.VectorUInt32_RemoveRange(swigCPtr, index, count);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static VectorUInt32 Repeat(uint value, int count) {
    global::System.IntPtr cPtr = tiledbcsPINVOKE.VectorUInt32_Repeat(value, count);
    VectorUInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorUInt32(cPtr, true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    tiledbcsPINVOKE.VectorUInt32_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    tiledbcsPINVOKE.VectorUInt32_Reverse__SWIG_1(swigCPtr, index, count);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, VectorUInt32 values) {
    tiledbcsPINVOKE.VectorUInt32_SetRange(swigCPtr, index, VectorUInt32.getCPtr(values));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(uint value) {
    bool ret = tiledbcsPINVOKE.VectorUInt32_Contains(swigCPtr, value);
    return ret;
  }

  public int IndexOf(uint value) {
    int ret = tiledbcsPINVOKE.VectorUInt32_IndexOf(swigCPtr, value);
    return ret;
  }

  public int LastIndexOf(uint value) {
    int ret = tiledbcsPINVOKE.VectorUInt32_LastIndexOf(swigCPtr, value);
    return ret;
  }

  public bool Remove(uint value) {
    bool ret = tiledbcsPINVOKE.VectorUInt32_Remove(swigCPtr, value);
    return ret;
  }

}

}
