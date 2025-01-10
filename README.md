# BinaryDataNunit

If you comment out [this line](https://github.com/m-nash/BinaryDataNunit/blob/main/BinaryDataNunit/TestClass.cs#L7) the test will run.
If it is uncommented the tests will not be found because there is some exception somewhere.

The only difference is that the top test uses a test case source which contains an empty BinaryData and the bottom one does not.

## System.Memory.Data

When we upgraded from 1.0.2 to 6.0.0 in [this PR](https://github.com/Azure/azure-sdk-for-net/commit/448d80d80ad0f3df69b96df080da6cf8b537e9d2#diff-93a28d9569550c68624a8ad2209a6fae1d4f88237e4b5414eed2ecac4ef8c98fR92) is when these tests started to fail.
There is potentially an issue both in System.Memory.Data as well as NUnit3TestAdapter which silently ignores some failure and should be calling the test out as broken.
