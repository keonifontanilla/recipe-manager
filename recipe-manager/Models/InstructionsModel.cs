﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_manager.Models
{
    /// <summary>
    /// This class is a model for instructions.
    /// </summary>
    public class InstructionsModel
    {
        /// <summary>
        /// This is the instruction's id.
        /// </summary>
        public int InstructionId { get; set; }
        /// <summary>
        /// The recipe's id.
        /// </summary>
        public int RecipeId { get; set; }
        /// <summary>
        /// This is the instruction.
        /// </summary>
        public string Instruction { get; set; }
        /// <summary>
        /// Displays instruction info.
        /// </summary>
        public string InstructionInfo
        {
            get { return $"{Instruction} {Environment.NewLine}"; }
        }

    }
}
