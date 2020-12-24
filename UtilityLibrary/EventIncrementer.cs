using System;
namespace UtilityLibrary
{
    public sealed class EventIncrementer
    {
        private static readonly Lazy<EventIncrementer> Lazy =
            new Lazy<EventIncrementer>(() =>
                new EventIncrementer());

        public static EventIncrementer Instance => Lazy.Value;

        public string EventSequence(string value)
        {
            return StringHelpers.IncrementAlphaNumericValue(value);
        }
    }
}