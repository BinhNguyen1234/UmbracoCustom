﻿using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class UmbracoCacheInstruction
{
    public int Id { get; set; }

    public DateTime UtcStamp { get; set; }

    public string JsonInstruction { get; set; } = null!;

    public string Originated { get; set; } = null!;

    public int InstructionCount { get; set; }
}
