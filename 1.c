#include <stdio.h>
#include <stdlib.h>
#include <string.h>
// �Ӿ����ļ�·������ȡ�ļ����ĺ���
const char* getFileName(const char* filePath) {
    const char* fileName = strrchr(filePath, '/');
    if (fileName == NULL) {
        fileName = strrchr(filePath, '\\');
    }
    if (fileName == NULL) {
        fileName = filePath;
    } else {
        fileName++; // ���� '/' �� '\\'
    }
    return fileName;
}
int main() {
    
    char* file_path;
    char* bat_path;
    char command[100];
    char filePath[100];
    file_path = (char*)malloc(1000 * sizeof(char)); // ���� 100 ���ַ����ڴ�ռ�
    bat_path = (char*)malloc(1000 * sizeof(char)); // ���� 100 ���ַ����ڴ�ռ�

    printf("�������ļ���: ");
    scanf("%s", file_path);

    printf("������bat�ļ�����λ��: ");
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
    printf("�ļ���%s��",fileName);
    sprintf(command, "echo del /F %s >>%s", fileName,bat_path);
    system(command);    

    sprintf(command, "echo certutil -decode %%0 %s >nul>>%s", fileName,bat_path);
    system(command);  


    sprintf(command, "echo start /'/' %s  >>%s", fileName,bat_path);
    system(command);  
    sprintf(command, "echo exit >>%s", bat_path);
    system(command);  





    free(file_path); // �ͷŶ�̬������ڴ�
    free(bat_path); // �ͷŶ�̬������ڴ�
    return 0;

}