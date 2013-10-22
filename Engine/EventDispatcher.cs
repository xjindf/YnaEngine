using System;
using System.Collections;
using System.Collections.Generic;

namespace Yna.Engine
{
    public class EventDispatcher
    {
        protected IDictionary<string, List<Action>> _listeners;

        public EventDispatcher()
        {
            _listeners = new Dictionary<string, List<Action>>();
        }

        public void Add(string eventName, Action callback)
        {
            if (!_listeners.ContainsKey(eventName))
                _listeners.Add(eventName, new List<Action>());

            _listeners[eventName].Add(callback);
        }

        public void Remove(string eventName)
        {
            if (_listeners.ContainsKey(eventName))
                _listeners.Remove(eventName);
        }

        public void Remove(string eventName, Action callback)
        {
            if (_listeners.ContainsKey(eventName) && _listeners[eventName].Contains(callback))
                _listeners[eventName].Remove(callback);
        }

        public void Send(string eventName)
        {
            if (_listeners.ContainsKey(eventName))
            {
                foreach (Action callback in _listeners[eventName])
                    callback();
            }
        }
    }
}