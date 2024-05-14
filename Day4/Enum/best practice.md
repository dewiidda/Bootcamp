## Strongly Type Parameters and Properties:
- DO use an enum to strongly type parameters, properties, and return values that represent sets of values.
- DO favor using an enum instead of static constants.
- DO NOT use an enum for open sets (such as operating system versions or names of friends).
-DO NOT provide reserved enum values intended for future use; you can add values to the existing enum later if needed1.
Reserved Values and Single-Value Enums:
- AVOID publicly exposing enums with only one value. Instead of using reserved parameters, leverage method overloading for future extensibility.
- DO NOT include sentinel values in enums; they can be confusing for users of the framework1.
## Default Value for Simple Enums:
- DO provide a value of zero on simple enums. Consider calling this value something like “None.”
- If a zero value is not appropriate, assign the most common default value for the enum as the underlying value of zero1.
## Underlying Type:
CONSIDER using Int32 (the default in most programming languages) as the underlying type of an enum unless:
- The enum is a flags enum with more than 32 flags.
- Interoperability with unmanaged code requires a different underlying type.
- Significant space savings are needed.
- If the enum is mainly used for flow of control, the size difference is less critical1.