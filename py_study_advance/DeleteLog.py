import sys
import os
import shutil

def backup_file(original_file_path, backup_root_dir="C:\\Users\\aweihou\\Desktop\\LifeCodeWithLog"):
    # 构建备份文件的完整路径
    relative_path = os.path.relpath(original_file_path, start="G:/LifeProject")
    # print(relative_path)
    backup_file_path = os.path.join(backup_root_dir, relative_path)
    # print(backup_file_path)

    # 创建目录（如果不存在）
    os.makedirs(os.path.dirname(backup_file_path), exist_ok=True)

    # 复制文件到备份位置
    shutil.copy2(original_file_path, backup_file_path)

    print(f"Backup created: {backup_file_path}")
    return backup_file_path
def remove_lines_from_file(file_path, target_string):

    # 首先备份文件
    desktop_path = os.path.join(os.path.expanduser("~"), "Desktop", "LifeCodeWithLog")
    print(desktop_path)
    backup_file_path = backup_file(file_path, desktop_path)

    with open(file_path, "r", encoding="utf-8") as file_:
        lines =file_.readlines()
        # print(lines)
        file_.close()

    with open(file_path, "w", encoding="utf-8") as file_:
        for line in lines:
            if target_string not in line:
                file_.write(line)

if __name__ == "__main__":
    file_path = sys.argv[1]
    log_strs = sys.argv[2:]
    print(log_strs)
    for target_string in log_strs:
        remove_lines_from_file(file_path, target_string)
