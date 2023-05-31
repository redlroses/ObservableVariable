﻿using System;

namespace ObservableVariable
{
    public interface IObservable<out T>
    {
        event Action<T> Changed;
    }
}