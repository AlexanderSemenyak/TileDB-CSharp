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

public class VectorOfVectorUInt64 : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<VectorUInt64>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VectorOfVectorUInt64(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VectorOfVectorUInt64 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VectorOfVectorUInt64() {
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
          tiledbcsPINVOKE.delete_VectorOfVectorUInt64(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public VectorOfVectorUInt64(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (VectorUInt64 element in c) {
      this.Add(element);
    }
  }

  public VectorOfVectorUInt64(global::System.Collections.Generic.IEnumerable<VectorUInt64> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (VectorUInt64 element in c) {
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

  public VectorUInt64 this[int index]  {
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

  public void CopyTo(VectorUInt64[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(VectorUInt64[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, VectorUInt64[] array, int arrayIndex, int count)
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

  public VectorUInt64[] ToArray() {
    VectorUInt64[] array = new VectorUInt64[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<VectorUInt64> global::System.Collections.Generic.IEnumerable<VectorUInt64>.GetEnumerator() {
    return new VectorOfVectorUInt64Enumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new VectorOfVectorUInt64Enumerator(this);
  }

  public VectorOfVectorUInt64Enumerator GetEnumerator() {
    return new VectorOfVectorUInt64Enumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class VectorOfVectorUInt64Enumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<VectorUInt64>
  {
    private VectorOfVectorUInt64 collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public VectorOfVectorUInt64Enumerator(VectorOfVectorUInt64 collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public VectorUInt64 Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (VectorUInt64)currentObject;
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
    tiledbcsPINVOKE.VectorOfVectorUInt64_Clear(swigCPtr);
  }

  public void Add(VectorUInt64 x) {
    tiledbcsPINVOKE.VectorOfVectorUInt64_Add(swigCPtr, VectorUInt64.getCPtr(x));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = tiledbcsPINVOKE.VectorOfVectorUInt64_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = tiledbcsPINVOKE.VectorOfVectorUInt64_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    tiledbcsPINVOKE.VectorOfVectorUInt64_reserve(swigCPtr, n);
  }

  public VectorOfVectorUInt64() : this(tiledbcsPINVOKE.new_VectorOfVectorUInt64__SWIG_0(), true) {
  }

  public VectorOfVectorUInt64(VectorOfVectorUInt64 other) : this(tiledbcsPINVOKE.new_VectorOfVectorUInt64__SWIG_1(VectorOfVectorUInt64.getCPtr(other)), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorOfVectorUInt64(int capacity) : this(tiledbcsPINVOKE.new_VectorOfVectorUInt64__SWIG_2(capacity), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  private VectorUInt64 getitemcopy(int index) {
    VectorUInt64 ret = new VectorUInt64(tiledbcsPINVOKE.VectorOfVectorUInt64_getitemcopy(swigCPtr, index), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private VectorUInt64 getitem(int index) {
    VectorUInt64 ret = new VectorUInt64(tiledbcsPINVOKE.VectorOfVectorUInt64_getitem(swigCPtr, index), false);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, VectorUInt64 val) {
    tiledbcsPINVOKE.VectorOfVectorUInt64_setitem(swigCPtr, index, VectorUInt64.getCPtr(val));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(VectorOfVectorUInt64 values) {
    tiledbcsPINVOKE.VectorOfVectorUInt64_AddRange(swigCPtr, VectorOfVectorUInt64.getCPtr(values));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorOfVectorUInt64 GetRange(int index, int count) {
    global::System.IntPtr cPtr = tiledbcsPINVOKE.VectorOfVectorUInt64_GetRange(swigCPtr, index, count);
    VectorOfVectorUInt64 ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorOfVectorUInt64(cPtr, true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, VectorUInt64 x) {
    tiledbcsPINVOKE.VectorOfVectorUInt64_Insert(swigCPtr, index, VectorUInt64.getCPtr(x));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, VectorOfVectorUInt64 values) {
    tiledbcsPINVOKE.VectorOfVectorUInt64_InsertRange(swigCPtr, index, VectorOfVectorUInt64.getCPtr(values));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    tiledbcsPINVOKE.VectorOfVectorUInt64_RemoveAt(swigCPtr, index);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    tiledbcsPINVOKE.VectorOfVectorUInt64_RemoveRange(swigCPtr, index, count);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static VectorOfVectorUInt64 Repeat(VectorUInt64 value, int count) {
    global::System.IntPtr cPtr = tiledbcsPINVOKE.VectorOfVectorUInt64_Repeat(VectorUInt64.getCPtr(value), count);
    VectorOfVectorUInt64 ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorOfVectorUInt64(cPtr, true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    tiledbcsPINVOKE.VectorOfVectorUInt64_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    tiledbcsPINVOKE.VectorOfVectorUInt64_Reverse__SWIG_1(swigCPtr, index, count);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, VectorOfVectorUInt64 values) {
    tiledbcsPINVOKE.VectorOfVectorUInt64_SetRange(swigCPtr, index, VectorOfVectorUInt64.getCPtr(values));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
