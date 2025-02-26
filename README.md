# Repro for file weirdness

The project includes a `filetoread.png` file which is 31.3kb.

When the sample is run, it deploys the file to the internal storage of the device.


## Expected behaviour

When the program is run, it should output something close to:

`File to be copied length: 32064 (should be: 32 064 bytes)`

Or at least the length should be fairly close to 30, 064.

## My behaviour

When I run the program, my output is:

`File to be copied length: 3964 (should be: 32 064 bytes)`

The actual length of the file changes between deploys. Sometimes it's as low as ~900. Sometimes it's a bit more. I never seem to be able to read the full file.
