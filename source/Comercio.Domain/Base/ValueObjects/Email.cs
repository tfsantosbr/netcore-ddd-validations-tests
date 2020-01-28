﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comercio.Domain.Base.ValueObjects
{
    public class Email
    {
        public Email(string endereco)
        {
            Endereco = endereco;
        }

        public string Endereco { get; private set; }
    }
}
