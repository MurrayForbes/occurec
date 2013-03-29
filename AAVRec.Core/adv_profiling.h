#ifndef ADV_PROFILING
#define ADV_PROFILING

#define _FILE_OFFSET_BITS  64
#include "stdio.h"


#if _MSC_VER
#define snprintf _snprintf
#endif

FILE* advfopen(const char* fileName, const char* modes);
size_t advfwrite(const void* pData, size_t size, size_t count, FILE* file);
void advfgetpos64(FILE* file, __int64* pos);
int advfsetpos64(FILE* file, const __int64* pos);
int advfseek(FILE* stream, long int off, int whence);
int advfclose(FILE* file);
int advfflush(FILE* file);

#endif