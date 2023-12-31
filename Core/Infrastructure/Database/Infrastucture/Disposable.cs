﻿using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Core.Infrastructure.Database.Infrastucture
{
    public abstract class Disposable : IDisposable
    {
        protected bool _disposed = false;
        protected abstract void Dispose(bool disposing);
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}