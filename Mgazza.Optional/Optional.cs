﻿namespace Mgazza.Optional
{
    public struct Optional<T> : IOptional
    {

        internal readonly T Val;

        public Optional(T value)
        {
            Val = value;
            HasBeenSet = true;
        }
        /*
        public Optional(Optional<T> value)
        {
            Val = (T)value.Value;
            HasBeenSet = value.HasBeenSet;
        }
        */
        public bool HasBeenSet { get; }

        public override bool Equals(object obj)
        {
            return Val == null ? base.Equals(obj) : obj.Equals(Val);
        }

        public override int GetHashCode()
        {
            return Val == null ? base.GetHashCode() : Val.GetHashCode();
        }

        public override string ToString()
        {
            return Val == null ? null : Val.ToString();
        }

        public static implicit operator T(Optional<T> optional)
        {
            return optional.Val;
        }

        public static implicit operator Optional<T>(T optional)
        {
            return new Optional<T>(optional);
        }

        public object Value => Val;
    }
}