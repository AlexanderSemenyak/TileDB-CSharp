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

public class Domain : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal Domain(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Domain obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Domain() {
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
          tiledbcsPINVOKE.delete_Domain(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Domain(Context ctx) : this(tiledbcsPINVOKE.new_Domain__SWIG_0(Context.getCPtr(ctx)), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Domain(Domain arg0) : this(tiledbcsPINVOKE.new_Domain__SWIG_1(Domain.getCPtr(arg0)), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public ulong cell_num() {
    ulong ret = tiledbcsPINVOKE.Domain_cell_num(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void dump(SWIGTYPE_p_FILE out_) {
    tiledbcsPINVOKE.Domain_dump__SWIG_0(swigCPtr, SWIGTYPE_p_FILE.getCPtr(out_));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void dump() {
    tiledbcsPINVOKE.Domain_dump__SWIG_1(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public tiledb_datatype_t type() {
    tiledb_datatype_t ret = (tiledb_datatype_t)tiledbcsPINVOKE.Domain_type(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint ndim() {
    uint ret = tiledbcsPINVOKE.Domain_ndim(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_tiledb__Dimension_t dimensions() {
    SWIGTYPE_p_std__vectorT_tiledb__Dimension_t ret = new SWIGTYPE_p_std__vectorT_tiledb__Dimension_t(tiledbcsPINVOKE.Domain_dimensions(swigCPtr), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Dimension dimension(uint idx) {
    Dimension ret = new Dimension(tiledbcsPINVOKE.Domain_dimension__SWIG_0(swigCPtr, idx), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Dimension dimension(string name) {
    Dimension ret = new Dimension(tiledbcsPINVOKE.Domain_dimension__SWIG_1(swigCPtr, name), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Domain add_dimension(Dimension d) {
    Domain ret = new Domain(tiledbcsPINVOKE.Domain_add_dimension(swigCPtr, Dimension.getCPtr(d)), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void add_int32_dimension(string name, int bound_lower, int bound_upper, int extent) {
    tiledbcsPINVOKE.Domain_add_int32_dimension(swigCPtr, name, bound_lower, bound_upper, extent);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_int64_dimension(string name, long bound_lower, long bound_upper, long extent) {
    tiledbcsPINVOKE.Domain_add_int64_dimension(swigCPtr, name, bound_lower, bound_upper, extent);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_uint64_dimension(string name, ulong bound_lower, ulong bound_upper, ulong extent) {
    tiledbcsPINVOKE.Domain_add_uint64_dimension(swigCPtr, name, bound_lower, bound_upper, extent);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_double_dimension(string name, double bound_lower, double bound_upper, double extent) {
    tiledbcsPINVOKE.Domain_add_double_dimension(swigCPtr, name, bound_lower, bound_upper, extent);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_string_dimension(string name) {
    tiledbcsPINVOKE.Domain_add_string_dimension(swigCPtr, name);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool has_dimension(string name) {
    bool ret = tiledbcsPINVOKE.Domain_has_dimension(swigCPtr, name);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
