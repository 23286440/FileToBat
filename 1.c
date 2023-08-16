#include <stdio.h>
#include <stdlib.h>
#include <string.h>
// 从绝对文件路径中提取文件名的函数
const char* getFileName(const char* filePath) {
    const char* fileName = strrchr(filePath, '/');
    if (fileName == NULL) {
        fileName = strrchr(filePath, '\\');
    }
    if (fileName == NULL) {
        fileName = filePath;
    } else {
        fileName++; // 跳过 '/' 或 '\\'
    }
    return fileName;
}
int main() {
    
    char* file_path;
    char* bat_path;
    char command[100];
    char filePath[100];
    file_path = (char*)malloc(1000 * sizeof(char)); // 分配 100 个字符的内存空间
    bat_path = (char*)malloc(1000 * sizeof(char)); // 分配 100 个字符的内存空间

    printf("请输入文件名: ");
    scanf("%s", file_path);

    printf("请输入bat文件保存位置: ");
    scanf("%s", bat_path);
  

    sprintf(command, "echo @echo off>%s", bat_path);
    system(command);

    sprintf(command, "echo goto CmdCode>>%s", bat_path);
    system(command);

    sprintf(command, "certutil -encode %s %s.temp", file_path,bat_path);
    system(command);

    sprintf(command, "copy %s+%s.temp %s", bat_path,bat_path,bat_path);
    system(command);

    sprintf(command, "echo :CmdCode>>%s", bat_path);
    system(command);



    const char* fileName = getFileName(filePath);
    printf("文件名%s；",fileName);
    sprintf(command, "echo del /F %s >>%s", fileName,bat_path);
    system(command);    

    sprintf(command, "echo certutil -decode %%0 %s >nul>>%s", fileName,bat_path);
    system(command);  


    sprintf(command, "echo start /'/' %s  >>%s", fileName,bat_path);
    system(command);  
    sprintf(command, "echo exit >>%s", bat_path);
    system(command);  





    free(file_path); // 释放动态分配的内存
    free(bat_path); // 释放动态分配的内存
    return 0;

}