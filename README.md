# C# Reflection və Attribute


## Resofurces
- (https://www.youtube.com/watch?v=-f7NmLWSIMU&list=PL8uXoSVYVb8TalGgO6vWd2dfyPkuNJC83&index=36)
- (https://dev.to/chakewitz/c-reflection-and-attributes-beyond-the-basics-2dd1) 
- Pro.CSharp.10.with.NET.6.pdf

## Mövzular
- Reflection nədir?
- Attribute istifadəsi
- Custom attribute yaratmaq
- Runtime analiz

## Mövzular Reflection - Performance Rules
--Reflection is slow:
--10-100x slower than normal code
--Uses more memory
--Hard to debug

## Use these first:
--Interfaces (IMyInterface)
--Generics (List<T>)
--Delegates (Func, Action)
--Dynamic keyword
--Source Generators (auto code at compile time)

## When to use Reflection?
--JSON serialization/deserialization
--Loading plugins
--Reading attributes (your case)
--Dependency Injection

## Remember: Reflection is the last option. If there's another way, use it.
