//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TileDB {

public class PairUInt64UInt64 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PairUInt64UInt64(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PairUInt64UInt64 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PairUInt64UInt64() {
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
          tiledbcsPINVOKE.delete_PairUInt64UInt64(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public PairUInt64UInt64() : this(tiledbcsPINVOKE.new_PairUInt64UInt64__SWIG_0(), true) {
  }

  public PairUInt64UInt64(ulong first, ulong second) : this(tiledbcsPINVOKE.new_PairUInt64UInt64__SWIG_1(first, second), true) {
  }

  public PairUInt64UInt64(PairUInt64UInt64 other) : this(tiledbcsPINVOKE.new_PairUInt64UInt64__SWIG_2(PairUInt64UInt64.getCPtr(other)), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public ulong first {
    set {
      tiledbcsPINVOKE.PairUInt64UInt64_first_set(swigCPtr, value);
    } 
    get {
      ulong ret = tiledbcsPINVOKE.PairUInt64UInt64_first_get(swigCPtr);
      return ret;
    } 
  }

  public ulong second {
    set {
      tiledbcsPINVOKE.PairUInt64UInt64_second_set(swigCPtr, value);
    } 
    get {
      ulong ret = tiledbcsPINVOKE.PairUInt64UInt64_second_get(swigCPtr);
      return ret;
    } 
  }

}

}