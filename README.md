# OldPhonePad Challenge

## Overview

Iron Software C# Coding Challenge.

## Key Rules

- Each key represents multiple letters. Pressing it repeatedly cycles through letters.
- Use `' '` (space) to pause when typing letters from the same button.
- `'*'` represents a backspace.
- `'#'` marks the end of input.

## Keypad Layout

```
1: &'(  
2: ABC  
3: DEF  
4: GHI  
5: JKL  
6: MNO  
7: PQRS  
8: TUV  
9: WXYZ  
0: (space)
```

## Usage

Run using any C# compiler or `dotnet run` if using .NET CLI.

## Sample Inputs & Outputs

| Input | Output |
|-------|--------|
| `33#` | E |
| `227*#` | B |
| `4433555 555666#` | HELLO |
| `8 88777444666*664#` | TEST |
| `222 2 22#` | CAB |

## Files

- `OldPhonePad.cs` — Well-structured and refactored code - core logic
- `Program.cs` — Comprehensive test cases - entry point and test cases
- `README.md` — A clear README - documentation

## License

MIT
