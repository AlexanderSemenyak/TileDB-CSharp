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

public class Filter : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal Filter(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Filter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Filter() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          tiledbcsPINVOKE.delete_Filter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Filter(Context ctx, tiledb_filter_type_t filter_type) : this(tiledbcsPINVOKE.new_Filter__SWIG_0(Context.getCPtr(ctx), (int)filter_type), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Filter() : this(tiledbcsPINVOKE.new_Filter__SWIG_1(), true) {
  }

  public Filter(Filter arg0) : this(tiledbcsPINVOKE.new_Filter__SWIG_2(Filter.getCPtr(arg0)), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public tiledb_filter_type_t filter_type() {
    tiledb_filter_type_t ret = (tiledb_filter_type_t)tiledbcsPINVOKE.Filter_filter_type(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string to_str(tiledb_filter_type_t type) {
    string ret = tiledbcsPINVOKE.Filter_to_str((int)type);
    return ret;
  }

}

}
