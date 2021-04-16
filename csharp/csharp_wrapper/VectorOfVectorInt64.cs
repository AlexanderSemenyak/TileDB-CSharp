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

public class VectorOfVectorInt64 : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<VectorInt64>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VectorOfVectorInt64(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VectorOfVectorInt64 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VectorOfVectorInt64() {
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
          tiledbcsPINVOKE.delete_VectorOfVectorInt64(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public VectorOfVectorInt64(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (VectorInt64 element in c) {
      this.Add(element);
    }
  }

  public VectorOfVectorInt64(global::System.Collections.Generic.IEnumerable<VectorInt64> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (VectorInt64 element in c) {
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

  public VectorInt64 this[int index]  {
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

  public void CopyTo(VectorInt64[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(VectorInt64[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, VectorInt64[] array, int arrayIndex, int count)
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

  public VectorInt64[] ToArray() {
    VectorInt64[] array = new VectorInt64[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<VectorInt64> global::System.Collections.Generic.IEnumerable<VectorInt64>.GetEnumerator() {
    return new VectorOfVectorInt64Enumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new VectorOfVectorInt64Enumerator(this);
  }

  public VectorOfVectorInt64Enumerator GetEnumerator() {
    return new VectorOfVectorInt64Enumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class VectorOfVectorInt64Enumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<VectorInt64>
  {
    private VectorOfVectorInt64 collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public VectorOfVectorInt64Enumerator(VectorOfVectorInt64 collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public VectorInt64 Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (VectorInt64)currentObject;
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
    tiledbcsPINVOKE.VectorOfVectorInt64_Clear(swigCPtr);
  }

  public void Add(VectorInt64 x) {
    tiledbcsPINVOKE.VectorOfVectorInt64_Add(swigCPtr, VectorInt64.getCPtr(x));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = tiledbcsPINVOKE.VectorOfVectorInt64_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = tiledbcsPINVOKE.VectorOfVectorInt64_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    tiledbcsPINVOKE.VectorOfVectorInt64_reserve(swigCPtr, n);
  }

  public VectorOfVectorInt64() : this(tiledbcsPINVOKE.new_VectorOfVectorInt64__SWIG_0(), true) {
  }

  public VectorOfVectorInt64(VectorOfVectorInt64 other) : this(tiledbcsPINVOKE.new_VectorOfVectorInt64__SWIG_1(VectorOfVectorInt64.getCPtr(other)), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorOfVectorInt64(int capacity) : this(tiledbcsPINVOKE.new_VectorOfVectorInt64__SWIG_2(capacity), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  private VectorInt64 getitemcopy(int index) {
    VectorInt64 ret = new VectorInt64(tiledbcsPINVOKE.VectorOfVectorInt64_getitemcopy(swigCPtr, index), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private VectorInt64 getitem(int index) {
    VectorInt64 ret = new VectorInt64(tiledbcsPINVOKE.VectorOfVectorInt64_getitem(swigCPtr, index), false);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, VectorInt64 val) {
    tiledbcsPINVOKE.VectorOfVectorInt64_setitem(swigCPtr, index, VectorInt64.getCPtr(val));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(VectorOfVectorInt64 values) {
    tiledbcsPINVOKE.VectorOfVectorInt64_AddRange(swigCPtr, VectorOfVectorInt64.getCPtr(values));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorOfVectorInt64 GetRange(int index, int count) {
    global::System.IntPtr cPtr = tiledbcsPINVOKE.VectorOfVectorInt64_GetRange(swigCPtr, index, count);
    VectorOfVectorInt64 ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorOfVectorInt64(cPtr, true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, VectorInt64 x) {
    tiledbcsPINVOKE.VectorOfVectorInt64_Insert(swigCPtr, index, VectorInt64.getCPtr(x));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, VectorOfVectorInt64 values) {
    tiledbcsPINVOKE.VectorOfVectorInt64_InsertRange(swigCPtr, index, VectorOfVectorInt64.getCPtr(values));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    tiledbcsPINVOKE.VectorOfVectorInt64_RemoveAt(swigCPtr, index);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    tiledbcsPINVOKE.VectorOfVectorInt64_RemoveRange(swigCPtr, index, count);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static VectorOfVectorInt64 Repeat(VectorInt64 value, int count) {
    global::System.IntPtr cPtr = tiledbcsPINVOKE.VectorOfVectorInt64_Repeat(VectorInt64.getCPtr(value), count);
    VectorOfVectorInt64 ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorOfVectorInt64(cPtr, true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    tiledbcsPINVOKE.VectorOfVectorInt64_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    tiledbcsPINVOKE.VectorOfVectorInt64_Reverse__SWIG_1(swigCPtr, index, count);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, VectorOfVectorInt64 values) {
    tiledbcsPINVOKE.VectorOfVectorInt64_SetRange(swigCPtr, index, VectorOfVectorInt64.getCPtr(values));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
