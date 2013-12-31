githook-version-example
=======================
Illustrates usage of a git hook, specifically a "post-merge" hook to embed the current git describe results into an assembly as an embedded resource and dispay the results.

To use:
1 - clone the repo
2 - copy the "post-merge" file into your .git/hooks directory
3 - make a change to this repo remotely (a newline to this file will work)
4 - pull the changes
5 - build and run the solution
