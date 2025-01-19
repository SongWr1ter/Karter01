# Karter01

## nodeCanvas

### 实体

- Dialogue Actor：进行对话的对象
  - 名字
  - icon
  - 字体颜色
  - 偏移？
- Dialogue Tree：存储对话信息
- Dialogue Tree Controller
  - startDialogue()
- black board:全局变量？是Global blackboard局部变量？是black board
  - 显示变量为文本:使用`[xxxBlackboardName/varibaleName]`
- 获取脚本里的数据:getfield/setfield、执行脚本里的函数:execution
  - 需要**显示拖拽**以获取目标的引用
- 脚本获取Dialogue Tree的数据：
  - `Blackboard.SetVariblevalue(string,value)`和`Blackboard.Getxxxx`
- task action：执行【动作】的节点
- condition branch：不满足条件的分支不会被显示

---

### 魔改UGUI

- [x] 更换TMP
- [ ] 加入富文本效果
