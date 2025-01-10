namespace BinaryDataNunit
{
    public static class TestSource
    {
        internal static List<BinaryData> EmptyBinaryData =
        [
            BinaryData.Empty,
        ];

        internal static List<BinaryData> NonEmptyBinaryData =
        [
            new BinaryData(" "u8.ToArray()),
        ];
    }
}
