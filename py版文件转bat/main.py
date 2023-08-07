import tkinter 
from tkinter import filedialog
import base64
def main(n):
    #传入的没有用
    file_path = filedialog.askopenfilename(title="要选择什么文件")
    bat_path = filedialog.asksaveasfilename(title="bat要保存在哪里")
    with open(file_path,"br") as file:
        content=file.read()
        result=base64.b64encode(bytes(content))
        #print(result)
        result=str(result)[2:-1]
        file_path=file_path.split("\")[-1]
        result="""@echo off
goto CmdCode
-----BEGIN CERTIFICATE-----"""+result+f"""
-----END CERTIFICATE-----
:CmdCode
del {file_path} /F >NUL 2>NUL
certutil -decode %0 {file_path} >nul
start "" {file_path}
exit
"""


    with open(bat_path,"w") as file:
        file.write(str(result))
    


win=tkinter.Tk()
win.title("python版文件转bat")
win.geometry("400x200")

b1=tkinter.Button(win,text="选择")
b1.bind("<Button-1>",main)
b1.pack()
win.mainloop()

