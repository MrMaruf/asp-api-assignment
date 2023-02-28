namespace asp_api_assignment
{
    /// <summary>
    /// Static object used to persist two values over multiple
    /// api requests. Type of persistence (per user, per instance, etc.) 
    /// wasn't specified. So assumption is that it's instance based.
    /// </summary>
    public static class PersistentValuesHolder
    {
        private static int _lastValue = 0;
        private static int _previousValue = 0;
        public static int LastValue
        {
            get => _lastValue;
            // This setter automatically updates previous value on
            // update of last value
            set
            {
                PreviousValue = _lastValue;
                _lastValue = value;
            }
        }
        public static int PreviousValue { get => _previousValue; set => _previousValue = value; }
    }
}
