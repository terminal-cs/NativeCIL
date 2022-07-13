namespace NativeCIL.Backend.IR;

public record IRInstruction(IROpCode OpCode, int Flags, object? Operand1, object? Operand2);