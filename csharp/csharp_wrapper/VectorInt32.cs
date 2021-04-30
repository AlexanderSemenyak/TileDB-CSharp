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

public class VectorInt32 : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<int>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VectorInt32(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VectorInt32 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VectorInt32() {
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
          tiledbcsPINVOKE.delete_VectorInt32(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public VectorInt32(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (int element in c) {
      this.Add(element);
    }
  }

  public VectorInt32(global::System.Collections.Generic.IEnumerable<int> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (int element in c) {
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

  public int this[int index]  {
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

  public void CopyTo(int[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(int[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, int[] array, int arrayIndex, int count)
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

  public int[] ToArray() {
    int[] array = new int[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<int> global::System.Collections.Generic.IEnumerable<int>.GetEnumerator() {
    return new VectorInt32Enumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new VectorInt32Enumerator(this);
  }

  public VectorInt32Enumerator GetEnumerator() {
    return new VectorInt32Enumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class VectorInt32Enumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<int>
  {
    private VectorInt32 collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public VectorInt32Enumerator(VectorInt32 collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public int Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (int)currentObject;
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
    tiledbcsPINVOKE.VectorInt32_Clear(swigCPtr);
  }

  public void Add(int x) {
    tiledbcsPINVOKE.VectorInt32_Add(swigCPtr, x);
  }

  private uint size() {
    uint ret = tiledbcsPINVOKE.VectorInt32_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = tiledbcsPINVOKE.VectorInt32_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    tiledbcsPINVOKE.VectorInt32_reserve(swigCPtr, n);
  }

  public VectorInt32() : this(tiledbcsPINVOKE.new_VectorInt32__SWIG_0(), true) {
  }

  public VectorInt32(VectorInt32 other) : this(tiledbcsPINVOKE.new_VectorInt32__SWIG_1(VectorInt32.getCPtr(other)), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorInt32(int capacity) : this(tiledbcsPINVOKE.new_VectorInt32__SWIG_2(capacity), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  private int getitemcopy(int index) {
    int ret = tiledbcsPINVOKE.VectorInt32_getitemcopy(swigCPtr, index);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private int getitem(int index) {
    int ret = tiledbcsPINVOKE.VectorInt32_getitem(swigCPtr, index);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, int val) {
    tiledbcsPINVOKE.VectorInt32_setitem(swigCPtr, index, val);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(VectorInt32 values) {
    tiledbcsPINVOKE.VectorInt32_AddRange(swigCPtr, VectorInt32.getCPtr(values));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorInt32 GetRange(int index, int count) {
    global::System.IntPtr cPtr = tiledbcsPINVOKE.VectorInt32_GetRange(swigCPtr, index, count);
    VectorInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorInt32(cPtr, true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, int x) {
    tiledbcsPINVOKE.VectorInt32_Insert(swigCPtr, index, x);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, VectorInt32 values) {
    tiledbcsPINVOKE.VectorInt32_InsertRange(swigCPtr, index, VectorInt32.getCPtr(values));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    tiledbcsPINVOKE.VectorInt32_RemoveAt(swigCPtr, index);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    tiledbcsPINVOKE.VectorInt32_RemoveRange(swigCPtr, index, count);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static VectorInt32 Repeat(int value, int count) {
    global::System.IntPtr cPtr = tiledbcsPINVOKE.VectorInt32_Repeat(value, count);
    VectorInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorInt32(cPtr, true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    tiledbcsPINVOKE.VectorInt32_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    tiledbcsPINVOKE.VectorInt32_Reverse__SWIG_1(swigCPtr, index, count);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, VectorInt32 values) {
    tiledbcsPINVOKE.VectorInt32_SetRange(swigCPtr, index, VectorInt32.getCPtr(values));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(int value) {
    bool ret = tiledbcsPINVOKE.VectorInt32_Contains(swigCPtr, value);
    return ret;
  }

  public int IndexOf(int value) {
    int ret = tiledbcsPINVOKE.VectorInt32_IndexOf(swigCPtr, value);
    return ret;
  }

  public int LastIndexOf(int value) {
    int ret = tiledbcsPINVOKE.VectorInt32_LastIndexOf(swigCPtr, value);
    return ret;
  }

  public bool Remove(int value) {
    bool ret = tiledbcsPINVOKE.VectorInt32_Remove(swigCPtr, value);
    return ret;
  }

}

}