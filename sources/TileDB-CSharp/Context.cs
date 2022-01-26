﻿using System;
using System.Text;
namespace TileDB
{
    public unsafe class Context : IDisposable
    {
        private TileDB.Interop.ContextHandle handle_;
        private TileDB.Config config_;
        public Context()
        {
            handle_ = new TileDB.Interop.ContextHandle();
            config_ = new Config();
            TileDB.Interop.tiledb_ctx_t* p = handle_;

            TileDB.Interop.tiledb_config_t* tiledb_config = config_.Handle;
            TileDB.Interop.Methods.tiledb_ctx_alloc(tiledb_config, &p);
            
        }

        public Context(Config config)
        {
            handle_ = new TileDB.Interop.ContextHandle();
            config_ = config;
            TileDB.Interop.tiledb_ctx_t* p = handle_;

            TileDB.Interop.tiledb_config_t* tiledb_config = config_.Handle;
            TileDB.Interop.Methods.tiledb_ctx_alloc(tiledb_config, &p);
        }

        public void Dispose()
        {
            TileDB.Interop.tiledb_ctx_t* p = handle_;
            TileDB.Interop.Methods.tiledb_ctx_free(&p);
        }

        internal TileDB.Interop.ContextHandle Handle 
        {
            get { return handle_; }
        }



        public string? stats()
        {
            string? result = "";
            TileDB.Interop.tiledb_ctx_t* p = handle_;



            //  use IntPtr
            //    IntPtr str_intptr = IntPtr.Zero;
            //    int status = TileDB.Interop.Methods.tiledb_ctx_get_stats(p, out str_intptr);
            //   return status != 0 ? "" : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(str_intptr);

            int max_num_chars = 1024;
            sbyte** pp_str = (sbyte**)System.Runtime.InteropServices.Marshal.AllocHGlobal(IntPtr.Size).ToPointer();
            pp_str[0] = (sbyte*)System.Runtime.InteropServices.Marshal.AllocHGlobal(max_num_chars).ToPointer();
            try
            {


                int status = TileDB.Interop.Methods.tiledb_ctx_get_stats(p, pp_str);
                if(status ==0)
                {
                    result = new string(pp_str[0]);
                }

            }
            finally
            {
                if(pp_str != null)
                {
                    System.Runtime.InteropServices.Marshal.FreeHGlobal((IntPtr)(pp_str[0]));
                    System.Runtime.InteropServices.Marshal.FreeHGlobal((IntPtr)(pp_str));
                }
            }

            return result;
        }

        public Config config()
        {
            return config_;
        }

        public string? last_error()
        {
            string? result = "";

            TileDB.Interop.tiledb_ctx_t* p = handle_;
            IntPtr str_intptr = IntPtr.Zero;
            TileDB.Interop.tiledb_error_t tiledb_error = new TileDB.Interop.tiledb_error_t();
            TileDB.Interop.tiledb_error_t* p_tiledb_error = &tiledb_error;
            int status = TileDB.Interop.Methods.tiledb_ctx_get_last_error(p, &p_tiledb_error);
            if(status ==0)
            {
  
                status = TileDB.Interop.Methods.tiledb_error_message(p_tiledb_error, out str_intptr);
                if(status ==0)
                {
                    result = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(str_intptr);
                }
            }
            TileDB.Interop.Methods.tiledb_error_free(&p_tiledb_error);
            
            return result;
        }

        public int cancel_tasks()
        {
            TileDB.Interop.tiledb_ctx_t* p = handle_;   
            return TileDB.Interop.Methods.tiledb_ctx_cancel_tasks(p);
        }

        public int set_tag(string key, string value)
        {
            TileDB.Interop.tiledb_ctx_t* p = handle_;
            return TileDB.Interop.Methods.tiledb_ctx_set_tag(p, key, value);
        }



    }
}