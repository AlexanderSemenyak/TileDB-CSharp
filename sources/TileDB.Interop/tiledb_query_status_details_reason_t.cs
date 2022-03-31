namespace TileDB.Interop
{
    [NativeTypeName("unsigned int")]
    public enum tiledb_query_status_details_reason_t : uint
    {
        TILEDB_REASON_NONE = 0,
        TILEDB_REASON_USER_BUFFER_SIZE = 1,
        TILEDB_REASON_MEMORY_BUDGET = 2,
    }
}
