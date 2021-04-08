//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace tiledb {

public class ObjectIter : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ObjectIter(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ObjectIter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ObjectIter() {
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
          tiledbcsPINVOKE.delete_ObjectIter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ObjectIter(Context ctx, string root) : this(tiledbcsPINVOKE.new_ObjectIter__SWIG_0(Context.getCPtr(ctx), root), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public ObjectIter(Context ctx) : this(tiledbcsPINVOKE.new_ObjectIter__SWIG_1(Context.getCPtr(ctx)), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_iter_policy(bool group, bool array) {
    tiledbcsPINVOKE.ObjectIter_set_iter_policy(swigCPtr, group, array);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_recursive(tiledb_walk_order_t walk_order) {
    tiledbcsPINVOKE.ObjectIter_set_recursive__SWIG_0(swigCPtr, (int)walk_order);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_recursive() {
    tiledbcsPINVOKE.ObjectIter_set_recursive__SWIG_1(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_non_recursive() {
    tiledbcsPINVOKE.ObjectIter_set_non_recursive(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_tiledb__ObjectIter__iterator begin() {
    SWIGTYPE_p_tiledb__ObjectIter__iterator ret = new SWIGTYPE_p_tiledb__ObjectIter__iterator(tiledbcsPINVOKE.ObjectIter_begin(swigCPtr), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_tiledb__ObjectIter__iterator end() {
    SWIGTYPE_p_tiledb__ObjectIter__iterator ret = new SWIGTYPE_p_tiledb__ObjectIter__iterator(tiledbcsPINVOKE.ObjectIter_end(swigCPtr), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
