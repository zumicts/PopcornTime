﻿using PopcornTime.AppEngine;

namespace PopcornTime.ViewModels
{
    internal class ViewModelLocator
    {
        public static AppKernel Kernel => App.Current?.Kernel ?? AppKernelFactory.Create();
        public MoviesViewModel Movies => Kernel.Resolve<MoviesViewModel>();
    }
}