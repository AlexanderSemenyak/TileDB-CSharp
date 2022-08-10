namespace TileDB.Interop
{
    [NativeTypeName("unsigned int")]
    public enum tiledb_filter_option_t : uint
    {
        TILEDB_COMPRESSION_LEVEL = 0,
        TILEDB_BIT_WIDTH_MAX_WINDOW = 1,
        TILEDB_POSITIVE_DELTA_MAX_WINDOW = 2,
        TILEDB_SCALE_FLOAT_BYTEWIDTH = 3,
        TILEDB_SCALE_FLOAT_FACTOR = 4,
        TILEDB_SCALE_FLOAT_OFFSET = 5,
    }
}
