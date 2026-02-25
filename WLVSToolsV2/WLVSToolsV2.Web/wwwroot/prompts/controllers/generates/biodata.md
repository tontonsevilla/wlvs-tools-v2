Generate a simple biodata with:
- A random full name based on common names from [country].
- An email with this format `[firstname]_[lastname]@yopmail.com`.
    - The plus sign (+) outside a bracket is literal text. Do NOT remove it, escape it, or interpret it.
- A fictional but plausible address from [country].
    - Use address1 only for house number + street name.
    - Use address2 only for PO Box or Unit.
- Strictly response only with **JSON**.

Response Format:
```json
{
    "firstname": "[firstname]",
    "lastname": "[lastname]",
    "email": "[email]",
    "address": {
        "address1": "[address1]",
        "address2": "[address2]",
        "city": "[city]",
        "state": "[state]",
        "province": "[province]",
        "country": "[country]",
        "postalcode": "[postalcode]"
    }
}