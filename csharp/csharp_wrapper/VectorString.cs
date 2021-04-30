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

public class VectorString : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<string>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VectorString(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VectorString obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VectorString() {
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
          tiledbcsPINVOKE.delete_VectorString(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public VectorString(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (string element in c) {
      this.Add(element);
    }
  }

  public VectorString(global::System.Collections.Generic.IEnumerable<string> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (string element in c) {
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

  public string this[int index]  {
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

  public void CopyTo(string[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(string[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, string[] array, int arrayIndex, int count)
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

  public string[] ToArray() {
    string[] array = new string[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<string> global::System.Collections.Generic.IEnumerable<string>.GetEnumerator() {
    return new VectorStringEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new VectorStringEnumerator(this);
  }

  public VectorStringEnumerator GetEnumerator() {
    return new VectorStringEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class VectorStringEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<string>
  {
    private VectorString collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public VectorStringEnumerator(VectorString collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public string Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (string)currentObject;
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
    tiledbcsPINVOKE.VectorString_Clear(swigCPtr);
  }

  public void Add(string x) {
    tiledbcsPINVOKE.VectorString_Add(swigCPtr, x);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = tiledbcsPINVOKE.VectorString_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = tiledbcsPINVOKE.VectorString_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    tiledbcsPINVOKE.VectorString_reserve(swigCPtr, n);
  }

  public VectorString() : this(tiledbcsPINVOKE.new_VectorString__SWIG_0(), true) {
  }

  public VectorString(VectorString other) : this(tiledbcsPINVOKE.new_VectorString__SWIG_1(VectorString.getCPtr(other)), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorString(int capacity) : this(tiledbcsPINVOKE.new_VectorString__SWIG_2(capacity), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  private string getitemcopy(int index) {
    string ret = tiledbcsPINVOKE.VectorString_getitemcopy(swigCPtr, index);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private string getitem(int index) {
    string ret = tiledbcsPINVOKE.VectorString_getitem(swigCPtr, index);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, string val) {
    tiledbcsPINVOKE.VectorString_setitem(swigCPtr, index, val);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(VectorString values) {
    tiledbcsPINVOKE.VectorString_AddRange(swigCPtr, VectorString.getCPtr(values));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorString GetRange(int index, int count) {
    global::System.IntPtr cPtr = tiledbcsPINVOKE.VectorString_GetRange(swigCPtr, index, count);
    VectorString ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorString(cPtr, true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, string x) {
    tiledbcsPINVOKE.VectorString_Insert(swigCPtr, index, x);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, VectorString values) {
    tiledbcsPINVOKE.VectorString_InsertRange(swigCPtr, index, VectorString.getCPtr(values));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    tiledbcsPINVOKE.VectorString_RemoveAt(swigCPtr, index);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    tiledbcsPINVOKE.VectorString_RemoveRange(swigCPtr, index, count);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static VectorString Repeat(string value, int count) {
    global::System.IntPtr cPtr = tiledbcsPINVOKE.VectorString_Repeat(value, count);
    VectorString ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorString(cPtr, true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    tiledbcsPINVOKE.VectorString_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    tiledbcsPINVOKE.VectorString_Reverse__SWIG_1(swigCPtr, index, count);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, VectorString values) {
    tiledbcsPINVOKE.VectorString_SetRange(swigCPtr, index, VectorString.getCPtr(values));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(string value) {
    bool ret = tiledbcsPINVOKE.VectorString_Contains(swigCPtr, value);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int IndexOf(string value) {
    int ret = tiledbcsPINVOKE.VectorString_IndexOf(swigCPtr, value);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(string value) {
    int ret = tiledbcsPINVOKE.VectorString_LastIndexOf(swigCPtr, value);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(string value) {
    bool ret = tiledbcsPINVOKE.VectorString_Remove(swigCPtr, value);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}