﻿using System.Runtime.InteropServices;

namespace Uvm.Kernel.Types
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    internal class OpCodes
    {
        public OpCodeType OpCode { get; private set; }
        public FlowControlType FlowControl { get; private set; }
        public OperandType OperandType { get; private set; }
        public string Name { get; private set; }
        public int Size { get; private set; }

        public OpCodes(string _Name, int _Size, OpCodeType _OpCode, FlowControlType _FlowControl, OperandType _OperandType)
        {
            Name = _Name;
            Size = _Size;
            OpCode = _OpCode;
            FlowControl = _FlowControl;
            OperandType = _OperandType;
        }
    }

    /// <summary>
    /// <see cref="https://docs.microsoft.com/zh-cn/dotnet/api/system.reflection.emit.flowcontrol"/>
    /// </summary>
    /// 参考MSIL flowcontrol
    internal enum FlowControlType : byte
    {
        Branch,
        Break,
        Call,
        Cond_Branch,
        Meta,
        Next,
        Phi,
        Return,
        Throw
    }

    /// <summary>
    /// <see cref="https://docs.microsoft.com/zh-cn/dotnet/api/system.reflection.emit.opcodes"/>
    /// </summary>
    /// 参考MSIL opcode
    internal enum OpCodeType : byte
    {
        Add,
        Add_Ovf,
        Add_Ovf_Un,
        And,
        Arglist,
        Beq,
        Beq_S,
        Bge,
        Bge_S,
        Bge_Un,
        Bge_Un_S,
        Bgt,
        Bgt_S,
        Bgt_Un,
        Bgt_Un_S,
        Ble,
        Ble_S,
        Ble_Un,
        Ble_Un_S,
        Blt,
        Blt_S,
        Blt_Un,
        Blt_Un_S,
        Bne_Un,
        Bne_Un_S,
        Box,
        Br,
        Br_S,
        Break,
        Brfalse,
        Brfalse_S,
        Brtrue,
        Brtrue_S,
        Call,
        Calli,
        Callvirt,
        Castclass,
        Ceq,
        Cgt,
        Cgt_Un,
        Ckfinite,
        Clt,
        Clt_Un,
        Constrained,
        Conv_I,
        Conv_I1,
        Conv_I2,
        Conv_I4,
        Conv_I8,
        Conv_Ovf_I,
        Conv_Ovf_I_Un,
        Conv_Ovf_I1,
        Conv_Ovf_I1_Un,
        Conv_Ovf_I2,
        Conv_Ovf_I2_Un,
        Conv_Ovf_I4,
        Conv_Ovf_I4_Un,
        Conv_Ovf_I8,
        Conv_Ovf_I8_Un,
        Conv_Ovf_U,
        Conv_Ovf_U_Un,
        Conv_Ovf_U1,
        Conv_Ovf_U1_Un,
        Conv_Ovf_U2,
        Conv_Ovf_U2_Un,
        Conv_Ovf_U4,
        Conv_Ovf_U4_Un,
        Conv_Ovf_U8,
        Conv_Ovf_U8_Un,
        Conv_R_Un,
        Conv_R4,
        Conv_R8,
        Conv_U,
        Conv_U1,
        Conv_U2,
        Conv_U4,
        Conv_U8,
        Cpblk,
        Cpobj,
        Div,
        Div_Un,
        Dup,
        Endfilter,
        Endfinally,
        Initblk,
        Initobj,
        Isinst,
        Jmp,
        Ldarg,
        Ldarg_0,
        Ldarg_1,
        Ldarg_2,
        Ldarg_3,
        Ldarg_S,
        Ldarga,
        Ldarga_S,
        Ldc_I4,
        Ldc_I4_0,
        Ldc_I4_1,
        Ldc_I4_2,
        Ldc_I4_3,
        Ldc_I4_4,
        Ldc_I4_5,
        Ldc_I4_6,
        Ldc_I4_7,
        Ldc_I4_8,
        Ldc_I4_M1,
        Ldc_I4_S,
        Ldc_I8,
        Ldc_R4,
        Ldc_R8,
        Ldelem,
        Ldelem_I,
        Ldelem_I1,
        Ldelem_I2,
        Ldelem_I4,
        Ldelem_I8,
        Ldelem_R4,
        Ldelem_R8,
        Ldelem_Ref,
        Ldelem_U1,
        Ldelem_U2,
        Ldelem_U4,
        Ldelema,
        Ldfld,
        Ldflda,
        Ldftn,
        Ldind_I,
        Ldind_I1,
        Ldind_I2,
        Ldind_I4,
        Ldind_I8,
        Ldind_R4,
        Ldind_R8,
        Ldind_Ref,
        Ldind_U1,
        Ldind_U2,
        Ldind_U4,
        Ldlen,
        Ldloc,
        Ldloc_0,
        Ldloc_1,
        Ldloc_2,
        Ldloc_3,
        Ldloc_S,
        Ldloca,
        Ldloca_S,
        Ldnull,
        Ldobj,
        Ldsfld,
        Ldsflda,
        Ldstr,
        Ldtoken,
        Ldvirtftn,
        Leave,
        Leave_S,
        Localloc,
        Mkrefany,
        Mul,
        Mul_Ovf,
        Mul_Ovf_Un,
        Neg,
        Newarr,
        Newobj,
        Nop,
        Not,
        Or,
        Pop,
        Prefix1,
        Prefix2,
        Prefix3,
        Prefix4,
        Prefix5,
        Prefix6,
        Prefix7,
        Prefixref,
        Readonly,
        Refanytype,
        Refanyval,
        Rem,
        Rem_Un,
        Ret,
        Rethrow,
        Shl,
        Shr,
        Shr_Un,
        Sizeof,
        Starg,
        Starg_S,
        Stelem,
        Stelem_I,
        Stelem_I1,
        Stelem_I2,
        Stelem_I4,
        Stelem_I8,
        Stelem_R4,
        Stelem_R8,
        Stelem_Ref,
        Stfld,
        Stind_I,
        Stind_I1,
        Stind_I2,
        Stind_I4,
        Stind_I8,
        Stind_R4,
        Stind_R8,
        Stind_Ref,
        Stloc,
        Stloc_0,
        Stloc_1,
        Stloc_2,
        Stloc_3,
        Stloc_S,
        Stobj,
        Stsfld,
        Sub,
        Sub_Ovf,
        Sub_Ovf_Un,
        Switch,
        Tailcall,
        Throw,
        Unaligned,
        Unbox,
        Unbox_Any,
        Volatile,
        Xor
    }

    /// <summary>
    /// <see cref="https://docs.microsoft.com/zh-cn/dotnet/api/system.reflection.emit.operandtype"/>
    /// </summary>
    /// 参考MSIL operandtype
    internal enum OperandType : byte
    {
        InlineBrTarget,
        InlineField,
        InlineI,
        InlineI8,
        InlineMethod,
        InlineNone,
        InlinePhi,
        InlineR,
        InlineSig,
        InlineString,
        InlineSwitch,
        InlineTok,
        InlineType,
        InlineVar,
        ShortInlineBrTarget,
        ShortInlineI,
        ShortInlineR,
        ShortInlineVar
    }
}