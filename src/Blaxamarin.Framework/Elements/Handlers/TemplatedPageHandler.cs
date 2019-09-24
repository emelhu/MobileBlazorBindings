﻿using Emblazon;
using System;
using XF = Xamarin.Forms;

namespace Blaxamarin.Framework.Elements.Handlers
{
    public class TemplatedPageHandler : PageHandler
    {
        public TemplatedPageHandler(EmblazonRenderer<IFormsControlHandler> renderer, XF.TemplatedPage templatedPageControl) : base(renderer, templatedPageControl)
        {
            TemplatedPageControl = templatedPageControl ?? throw new ArgumentNullException(nameof(templatedPageControl));
        }

        public XF.TemplatedPage TemplatedPageControl { get; }
    }
}