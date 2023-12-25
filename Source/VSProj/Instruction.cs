/*
 * Tencent is pleased to support the open source community by making InjectFix available.
 * Copyright (C) 2019 THL A29 Limited, a Tencent company.  All rights reserved.
 * InjectFix is licensed under the MIT License, except for the third-party components listed in the file 'LICENSE' which may be subject to their corresponding license terms. 
 * This file is subject to the terms and conditions defined in file 'LICENSE', which is part of this source code package.
 */

namespace IFix.Core
{
    public enum Code
    {
        Conv_R8,
        Ldelem_I8,
        Newarr,
        Conv_I2,
        Localloc,
        Ldc_R4,
        Conv_I,
        Ldelem_I1,
        Div_Un,
        Ldelema,
        Blt,
        Conv_Ovf_I8,
        Sizeof,
        CallExtern,
        Shl,
        Ldind_U2,
        Arglist,
        Div,
        Ldelem_R4,
        Endfilter,
        Conv_Ovf_U1,
        Stelem_I2,
        Newanon,
        Ldlen,
        Ldind_I4,
        Ldvirtftn,
        No,
        Stsfld,
        Dup,
        Ldelem_R8,
        Refanyval,
        Stind_I8,
        Ldarg,
        Conv_U,
        Nop,
        Clt_Un,
        Ldsflda,
        Or,
        Mul_Ovf,
        Clt,
        Conv_R_Un,
        Ldelem_Ref,
        Conv_Ovf_I8_Un,
        Stelem_R4,
        Unbox,
        Bgt_Un,
        Bge,
        Conv_Ovf_I2,
        Cgt_Un,
        Starg,
        Brfalse,
        Volatile,
        Readonly,
        Ldstr,
        Add_Ovf,
        Cpblk,
        Conv_Ovf_I1,
        Stelem_I,
        Not,
        Castclass,
        Throw,
        Refanytype,
        Callvirtvirt,
        Ldind_U4,
        Stelem_Any,
        Ldelem_I,
        //Calli,
        Ret,
        Ldelem_U1,
        Ldelem_Any,
        Ldc_I8,
        Stloc,
        Ldarga,
        Conv_R4,
        Ldelem_U2,
        Ldflda,
        Sub,
        Ldnull,
        Conv_Ovf_U4_Un,
        Stelem_I4,
        Ldind_U1,
        Bgt,
        Jmp,
        Initobj,
        Ldind_I,
        Ldelem_U4,
        Callvirt,
        Ble_Un,
        Sub_Ovf_Un,
        Shr_Un,
        Ldc_R8,
        Ldtoken,
        Ldsfld,
        Conv_Ovf_U4,
        Rethrow,
        Pop,
        Conv_Ovf_U8,
        Brtrue,
        Conv_I8,
        Stfld,
        Mkrefany,
        Stind_I,
        Conv_Ovf_I2_Un,
        Ldind_I2,
        Ckfinite,
        Endfinally,
        Ldind_R4,
        Sub_Ovf,
        Ldloc,
        Conv_Ovf_I,
        Newobj,
        Rem,
        Constrained,
        Mul_Ovf_Un,
        Beq,
        Ldind_R8,
        Conv_Ovf_U8_Un,
        Ldelem_I2,
        Conv_Ovf_I_Un,
        Ldvirtftn2,
        Conv_I4,
        Stind_Ref,
        Blt_Un,
        Initblk,
        Ble,
        Cpobj,
        Ceq,
        And,
        Stelem_I1,
        Conv_Ovf_U,
        Br,
        Rem_Un,
        Isinst,
        Unbox_Any,
        Conv_Ovf_I4_Un,
        Ldfld,
        Stobj,
        Ldloca,
        Ldind_I8,
        Stind_R4,
        Ldc_I4,
        Shr,
        Unaligned,
        Leave,
        Add,
        Ldftn,

        //Pseudo instruction
        StackSpace,
        Tail,
        Add_Ovf_Un,
        Xor,
        Conv_U2,
        Ldind_I1,
        Conv_Ovf_U_Un,
        Mul,
        Conv_Ovf_I4,
        Stelem_Ref,
        Conv_Ovf_U2_Un,
        Conv_Ovf_U1_Un,
        Neg,
        Stelem_I8,
        Ldind_Ref,
        Conv_U8,
        Conv_I1,
        Stelem_R8,
        Stind_R8,
        Call,
        Conv_U1,
        Bne_Un,
        Stind_I1,
        Box,
        Conv_Ovf_U2,
        Ldtype, // custom
        Bge_Un,
        Conv_Ovf_I1_Un,
        Break,
        Ldobj,
        Switch,
        Cgt,
        Stind_I4,
        Ldelem_I4,
        Conv_U4,
        Stind_I2,
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Instruction
    {
        /// <summary>
        /// 指令MAGIC
        /// </summary>
        public const ulong INSTRUCTION_FORMAT_MAGIC = 8054543981008184111;

        /// <summary>
        /// 当前指令
        /// </summary>
        public Code Code;

        /// <summary>
        /// 操作数
        /// </summary>
        public int Operand;
    }

    public enum ExceptionHandlerType
    {
        Catch = 0,
        Filter = 1,
        Finally = 2,
        Fault = 4
    }

    public sealed class ExceptionHandler
    {
        public System.Type CatchType;
        public int CatchTypeId;
        public int HandlerEnd;
        public int HandlerStart;
        public ExceptionHandlerType HandlerType;
        public int TryEnd;
        public int TryStart;
    }
}