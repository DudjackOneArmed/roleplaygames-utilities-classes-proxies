namespace System
{
    /// <summary>
    /// Proxy for <see cref="Random"/>>
    /// </summary>
    public class RandomProxy : IRandom
    {
        /// <summary>
        /// Provides a thread-safe System.Random instance that may be used concurrently from any thread.
        /// </summary>
        public static IRandom Shared => new RandomProxy(Random.Shared);

        private readonly Random _random;

        /// <summary>
        /// Initializes a new instance of the System.RandomProxy class using a default seed value.
        /// </summary>
        public RandomProxy() : this(new Random())
        {

        }

        /// <summary>
        /// Initializes a new instance of the System.RandomProxy class, using the specified seed value.
        /// </summary>
        /// <param name="seed">A number used to calculate a starting value for the pseudo-random number sequence. If a negative number is specified, the absolute value of the number is used.</param>
        public RandomProxy(int seed) : this(new Random(seed))
        {

        }

        /// <summary>
        /// Initializes a new instance of the System.RandomProxy class, using the specified seed value.
        /// </summary>
        /// <param name="random">Base instance of the System.Random class</param>
        public RandomProxy(Random random)
        {
            _random = random;
        }

        /// <inheritdoc/>
        public int Next() => _random.Next();

        /// <inheritdoc/>
        public int Next(int maxValue) => _random.Next(maxValue);

        /// <inheritdoc/>
        public int Next(int minValue, int maxValue) => _random.Next(minValue, maxValue);

        /// <inheritdoc/>
        public void NextBytes(byte[] buffer) => _random.NextBytes(buffer);

        /// <inheritdoc/>
        public void NextBytes(Span<byte> buffer) => _random.NextBytes(buffer);

        /// <inheritdoc/>
        public double NextDouble() => _random.NextDouble();

        /// <inheritdoc/>
        public long NextInt64() => _random.NextInt64();

        /// <inheritdoc/>
        public long NextInt64(long maxValue) => _random.NextInt64(maxValue);

        /// <inheritdoc/>
        public long NextInt64(long minValue, long maxValue) => _random.NextInt64(minValue, maxValue);

        /// <inheritdoc/>
        public float NextSingle() => _random.NextSingle();
    }
}
