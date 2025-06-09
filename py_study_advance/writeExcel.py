import openpyxl
import os
def write_to_excel(data, output_file):
    if os.path.exists(output_file):
        os.remove(output_file)

    # 创建一个新的工作簿
    workbook = openpyxl.Workbook()
    sheet = workbook.active
    sheet.title = "数据表"  # 表名

    # 写入表头
    sheet.append(["加速高度", "匀速高度", "减速高度", "滞空高度"])
    # 将数据按照 4 个一组分块写入
    for i in range(0, len(data), 4):
        row = data[i:i + 4]  # 每次取 4 个数据
        sheet.append(row)  # 写入 Excel 表的一行

    sheet.column_dimensions['A'].width = 30  # 加速时间列
    sheet.column_dimensions['B'].width = 30  # 匀速时间列
    sheet.column_dimensions['C'].width = 30  # 减速时间列
    sheet.column_dimensions['D'].width = 30  # 滞空时间列

    # 保存 Excel 文件
    workbook.save(output_file)
    print(f"数据已成功写入到 '{output_file}' 文件中！")

    # 打开文件 windows系统下
    if os.name == 'nt':
        os.startfile(output_file)


if __name__ == '__main__':

    with open('C:\\Users\\aweihou\\Desktop\\temp.py', 'r', encoding='utf-8') as f:
        data = [float(line.strip()) for line in f if line.strip()]

    output_file = 'output.xlsx'
    write_to_excel(data, output_file)