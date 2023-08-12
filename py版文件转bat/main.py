import tkinter 
from tkinter import filedialog
import base64
def main(n):
    #传入的没有用
    
    
    file_path = filedialog.askopenfilename(title="要选择什么文件")
    bat_path = filedialog.asksaveasfilename(title="bat要保存在哪里",filetypes=(("Batch files", "*.bat"), ("All files", "*.*")))
    print(file_path,bat_path,type(file_path))

    import base64

    # 读取文件并将其转换为Base64编码
    with open(file_path, 'rb') as file:
        encoded = base64.b64encode(file.read())
    file_path=file_path.split("/")[-1].replace(" ","")    
    result="""
    
@echo off
goto CmdCode
-----BEGIN CERTIFICATE-----
"""+encoded.decode('utf-8')+f"""
-----END CERTIFICATE-----
:CmdCode
del {file_path} /F >NUL 2>NUL
certutil -decode %0 {file_path} >nul
start "" {file_path}
exit
"""
    # 将Base64编码写入另一个文件
    with open(bat_path, 'w') as file:
        file.write(result)


win=tkinter.Tk()
win.title("python版文件转bat")
win.geometry("400x200")

b1=tkinter.Button(win,text="选择")
b1.bind("<Button-1>",main)
b1.pack()
win.mainloop()

