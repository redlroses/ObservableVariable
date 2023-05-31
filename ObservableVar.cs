﻿using System;

namespace ObservableVariable
{
    public class ObservableVar<T> : IObservable<T>
    {
        private T _value;

        public event Action<T> Changed;

        public ObservableVar(T value) => _value = value;

        public T Value
        {
            get => _value;
            set
            {
                _value = value;
                Changed?.Invoke(_value);
            }
        }
    }
}