// Created by WHMHammer on Feb. 14th, 2022
// Translated from CLang_en.cs
// Edited by Glimmer_Miku on Dec. 23th, 2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FDK;

namespace TJAPlayer3
{
    internal class CLang_zh : ILang
    {
        string ILang.GetString(int idx)
        {
            if (!dictionnary.ContainsKey(idx))
                return "【尚无翻译】";

            return dictionnary[idx];
        }


        private static readonly Dictionary<int, string> dictionnary = new Dictionary<int, string>
        {
            [0] = "更改游戏及菜单的显示语言。",
            [1] = "系统语言",
            [2] = "<< 返回上级菜单",
            [3] = "返回至上级菜单。",
            [4] = "重新载入曲目",
            [5] = "重新扫描曲目文件夹并载入曲目。",
            [10148] = "重新载入曲目（硬重新加载）",
            [10149] = "删除既有数据库并\n" + 
                      "从空白重新扫描曲目文件夹并载入曲目。",
            [6] = "玩家数量",
            [7] = "选择游玩的玩家数量，最多同时可有 5 人游玩。",
            [8] = "完美模式",
            [9] = "选择多少个“不可”会导致演奏失败，\n" +
                  "将该选项设为 0 以禁用此选项。",
            [10] = "曲目播放速度",
            [11] = "调整曲目播放速度\n" +
                   "当时间拉伸模式开启，且曲目播放速度低于 0.9x 时\n" +
                   "可能会出现问题。\n" +
                   "提示：此选项会影响曲目音高。",
            [12] = "AI 等级",
            [13] = "决定 AI 的准确度。\n" +
                   "— 0：关闭\n" +
                   "— 1+：2P 会变为 AI\n" +
                   "此选项会在自动模式开启时禁用。",
            [14] = "全局偏移量",
            [15] = "更改所有谱面的偏移量。\n" +
                   "设定范围：-999—999ms\n" +
                   "可设为负值以减少输入延迟。",
            [16] = "布局模式",
            [17] = "设置选曲界面时歌曲的显示布局模式。" +
		   "— 0：自上至下斜向\n" +
                   "— 1：纵向\n" +
                   "— 2：自下至上斜向\n" +
                   "— 3：右向半圆\n" +
                   "— 4：左向半圆",
            [18] = "此选项作用不明，会导致 CPU 占用增加，\n" +
                   "并且当曲目播放速度低于 0.9x 时可能会出现问题。",
            [19] = "切换全屏/窗口模式。",
            [20] = "移植 DTXMania 导致的无效设置\n" +
                   "没有任何作用",
            [21] = "选择随机选曲时是否访问子文件夹",
            [22] = "选择是否开启垂直同步。打开后帧率会上限为 60 FPS，音符滚动会更加顺畅，\n" +
                   "但输入延迟会增加。\n" +
                   "关闭后帧率不会受到限制，输入延迟会降低，\n" +
                   "但音符滚动会更加不稳定",
            [23] = "选择是否开启背景视频。" +
		   "若此选项开启但文件夹中没有视频，背景会变为全黑",
            [24] = "选择是否播放背景动画。",
            [25] = "曲目预览等待时间\n" +
                   "降低该值或将导致预览在滚动曲目列表时就开始播放\n" +
                   "范围：0—10000ms",
            [26] = "移植 DTXMania 导致的无效设置\n" +
                   "没有任何作用",
            [27] = "选择是否开启 Debug 模式。开启后右下角会显示额外信息\n" +
                   "敲击音效关闭时会显示延迟校准。",
            [28] = "调整视频播放时音符跑道的透明度。\n" +
                   "— 0：完全透明，\n" +
                   "— 255：完全不透明",
            [29] = "选择是否播放音乐。",
            [30] = "选择是否在曲目文件夹中自动存储 score.ini 文件\n" +
                   "曲目偏移量被保存在该文件中，\n" +
                   "所以关闭敲击音效时请打开此选项。",
            [31] = "用于 BSGain 声音设置的无效选项\n" +
                   "鉴于 BSGain 支持不可用，\n" +
                   "此选项没有任何作用",
            [32] = "用于正常化 BSGain 音量的无效选项\n" +
                   "鉴于 BSGain 支持不可用，\n" +
                   "此选项没有任何作用",
            [33] = "切换是否使用 SONGVOL 元数据的部分无效选项。" +
		   "— 0—99：降低音量，\n" +
                   "— 100+：没有任何作用。",
            [34] = "调整“咚”“咔”音量。\n" +
                   "— 0：关闭敲击音效\n" +
                   "你必须在调整完成该项设置后重启游戏才能应用更改。",
            [35] = "调整小咚的语音音量\n" +
                   "你必须在调整完成该项设置后重启游戏才能应用更改。",
            [36] = "调整背景音乐音量\n" +
                   "你必须在调整完成该项设置后重启游戏才能应用更改。",
            [37] = "控制每次按下调整音量按键时音量的更改幅度。\n" +
                   "更改范围：1—20",
            [38] = "游戏开始前的等待时间\n" +
                   "降低该值可能会导致曲目过早开始播放。",
            [39] = "选择是否自动保存结果自动截屏\n" +
                   "只有当获得新高分时才会截屏，\n" +
                   "但最高分并不一定是最佳演奏。",
            [40] = "选择是否在 Discord 上共享曲目信息。",
            [41] = "开启时所有输入都会被保留，但输入采样率会会降低，\n" +
                   "关闭时部分输入可能会被丢弃，但输入采样率会增高。",
            [42] = "选择游戏关闭时是否生成 TJAPlayer3.log 文件\n" +
                   "该文件用于追踪游戏的性能并记录报错信息。",
            [43] = "ASIO：\n" +
                   "— 只在支持 ASIO 的音频设备上生效\n" +
                   "— 输入延迟最低\n" +
                   "WASAPI：\n" +
                   "— 仅与 Windows 兼容\n" +
                   "— 输入延迟次低\n" +
                   "BASS：\n" +
                   "— 支持所有平台\n" +
                   "退出设置界面以使此选项生效。",
            [44] = "调整声音播放模式为 WASAPI 时的声音缓冲。\n" +
		   "没有出现如曲目冻结或时间错误的声音问题时，该项设置越小越好。\n" +
                   "建议设为 0 以使用估计值或通过不断尝试进行调整。\n" +
                   "退出设置界面以使此选项生效。",
            [45] = "选择播放模式为 ASIO 时合适的设备\n" +
		   "退出设置界面以使此选项生效。",
            [46] = "开启时音符滚动会更加顺畅，但或将导致声音延迟。\n" +
                   "关闭会确保无声音延迟，但音符滚动会更加不稳定。\n" +
                   "关闭时 DTXMania 会使用其原始的计时器。\n" +
                   "其效果反之亦然。",
            [47] = "显示角色 (Character) 图片。",
            [48] = "显示舞者 (Dancer) 图片。",
            [49] = "显示人群 (Mob) 图片。",
            [50] = "显示跑者 (Runner) 图片。",
            [51] = "显示页脚 (Footer) 图片。",
            [52] = "选择是否在加载曲目时就开始渲染图片。",
            [53] = "显示迷你角色图片。",
            [54] = "从 System 文件夹中选择皮肤。\n（安装皮肤时请将皮肤文件夹放入 System 文件夹中，重启游戏并在此选择）",
            [55] = "二级菜单：设置系统按键",
            [56] = "玩家 1 自动演奏",
            [57] = "切换玩家 1 是否自动演奏。",
            [58] = "玩家 2 自动演奏",
            [59] = "切换玩家 2 是否自动演奏。",
            [60] = "连打速度",
            [61] = "设置自动演奏时连打的每秒敲击次数。\n" +
                   "不对气球生效。\n" +
                   "0 关闭自动滚奏，最快每帧一次。",
            [62] = "卷动速度",
            [63] = "更改音符卷动速度。\n" +
                   "范围：0.1x—200x\n" +
                   "（0.5x 速度表示半速滚动）",
            [64] = "完美模式",
            [65] = "选择打出多少个“不可”时会导致演奏失败。\n" +
                   "— 0：禁用此选项",
            [66] = "音符变更",
            [67] = "音符随机出现。\n\n" +
                   "— PART：每小节内随机交换跑道\n" +
                   "— SUPER：随机交换音符\n" +
                   "— HYPER：随机交换所有音符\n" +
                   "（跑道数量也会更改）",
            [68] = "隐藏音符",
            [69] = "DORON：隐藏音符\n" +
                   "隐形：隐藏音符和下方文字。",
            [70] = "无信息模式",
            [71] = "打开会关闭曲目信息显示，\n" +
                   "关闭会打开曲目信息显示。",
            [72] = "严格模式",
            [73] = "开启会将所有“可”变为“不可”。",
            [74] = "锁定音符模式",
            [75] = "切换是否会将空白处的敲击判断为“不可”。",
            [76] = "最小连击显示",
            [77] = "选择开始显示连击的数量\n。" +
                   "范围：1—99999",
            [78] = "判定圆圈调整",
            [79] = "升高此值会使判定区域右移，\n" +
                   "降低此值会使判定区域左移。\n" +
                   "范围：-99—99ms\n" +
                   "可将此项设为负值以降低输入延迟。",
            [80] = "默认难度",
            [81] = "除非该选项被设为里魔王 (Edit) 或在选择难度时\n" +
                   "在表魔王上按右方向键，里魔王难度不会显示。",
            [82] = "记分模式",
            [83] = "— TYPE-A：第一代\n" +
                   "— TYPE-B：第二代\n" +
                   "— TYPE-C：第三代",
            [84] = "使所有音符得分相同，\n" +
                   "使用第四代公式。",
            [85] = "谱面分歧提示",
            [86] = "切换是否打开谱面分歧条件显示。\n" +
                   "自动演奏模式下此项不起作用。",
            [87] = "谱面分歧动画",
            [88] = "— TYPE-A：第二代\n" +
                   "— TYPE-B：第三代",
            [89] = "生存模式",
            [90] = "此模式不可用\n" +
                   "此模式实现了一个类似 StepMania 的计时器系统，\n" +
                   "但部分代码缺失导致功能受限。",
            [91] = "大音符判断",
            [92] = "切换双击大音符时是否获得奖励。\n" +
                   "开启时单击大音符会导致音符消失前出现视觉延迟，\n" +
                   "双击会获得双倍分数。\n" +
                   "关闭时单击与敲击普通音符效果一致并会获得双倍分数。\n" +
                   "尝试双击或将导致下个音符被敲击。",
            [93] = "显示判定情况",
            [94] = "在左下方显示良、可、不可数量。\n" +
                   "（仅在单人模式下生效）",
            [95] = "游戏按键设置",
            [96] = "二级菜单：设置游戏按键",
            [99] = "左红",

            [9992] = "通过游玩期间隐藏多数视觉火焰和效果简化描绘。",
            [9993] = "简化模式",
	    
	    [9994] = "贴图加载方式：\n" +
    		     "启动时不会未响应。\n" +
		     "如果某些贴图变黑，请关闭这项设置。\n" +
		     "该项设置将在重启 OpenTaiko 后生效。\n",
            [9995] = "异步贴图加载",

            [9996] = "绘制方式：\n" +
                    "从 OpenGL，Vulkan，DirectX11 或 DirectX12 中选择。\n" +
                    "OpenGL 速度较慢，但稳定性和兼容性较好。\n" +
                    "Vulkan 在 Linux 上速度最快。\n" +
                    "DirectX11 较快且稳定，但只能在 Windows 上使用。\n" +
                    "DirectX12 效率很高，但只能在 Windows 上使用。\n" +
                    "\n" +
                    "该项设置将会在游戏重启后生效。\n",
            [9997] = "画面渲染 API",

            [9998] = "当使用 Bass 模式时的缓冲区大小：\n" +
                    "— 范围： 0-99999ms。\n" +
                    "— 0：系统决定该值的大小。\n" +
                    "该值越小，音频卡顿/延迟会更小，但或导致声音异常或爆音。\n" +
                    "退出设置界面以使此选项生效。",
            [9999] = "Bass 模式缓冲区大小",
            [10000] = "鼓按键分配：\n分配左红按键",
            [10001] = "右红",
            [10002] = "鼓按键分配：\n分配右红按键",
            [10003] = "左蓝",
            [10004] = "鼓按键分配：\n分配左蓝按键",
            [10005] = "右蓝",
            [10006] = "鼓按键分配：\n分配右蓝按键",
            [10007] = "左红（玩家 2）",
            [10008] = "鼓按键分配：\n分配 玩家 2 左红按键",
            [10009] = "右红（玩家 2）",
            [10010] = "鼓按键分配：\n分配 玩家 2 右红按键",
            [10011] = "左蓝（玩家 2）",
            [10012] = "鼓按键分配：\n分配 玩家 2 左蓝按键",
            [10013] = "右蓝（玩家 2）",
            [10014] = "鼓按键分配：\n分配 玩家 2 右蓝按键",
            [10018] = "时间拉伸模式",
            [10019] = "全屏模式",
            [10020] = "游戏结束模式",
            [10021] = "随机选曲时访问子文件夹",
            [10022] = "垂直同步",
            [10023] = "播放背景视频",
            [10024] = "显示背景动画",
            [10025] = "曲目预览缓冲",
            [10026] = "图片预览缓冲",
            [10027] = "调试模式",
            [10028] = "跑道不透明度",
            [10029] = "播放背景音乐",
            [10030] = "保存得分",
            [10031] = "应用响度 (LOUDNESS) 元信息",
            [10032] = "目标响度",
            [10033] = "应用音量 (SONGVOL) 元信息",
            [10034] = "音效音量",
            [10035] = "语音音量",
            [10036] = "背景音乐音量",
            [10037] = "键盘音量更改幅度",
            [10038] = "曲目播放缓冲",
            [10039] = "自动截屏",
            [10040] = "Discord 状态显示",
            [10041] = "输入缓冲模式",
            [10042] = "创建报错记录",
            [10043] = "声音播放模式",
            [10044] = "WASAPI 缓冲区大小",
            [10045] = "ASIO 播放设备",
            [10046] = "操作系统计时器模式",
            [10047] = "显示角色 (Character)",
            [10048] = "显示舞者 (Dancer)",
            [10049] = "显示人群 (Mob)",
            [10050] = "显示跑者 (Runner)",
            [10051] = "显示页脚 (Footer)",
            [10052] = "快速渲染",
            [10053] = "显示迷你角色",
            [10054] = "当前皮肤",
            [10055] = "系统按键设置",
            [10056] = "隐藏段位/塔",
            [10057] = "在太鼓模式菜单中隐藏段位和塔谱面。\n重新载入曲目以使此选项生效。",
            [10058] = "曲目预览音量",
            [10059] = "调整曲目预览音量。\n" +
                      "必须在调整完成该项设置后重启游戏才能应用更改。",
            [10060] = "拍手",
            [10061] = "康加鼓按键分配：\n分配拍手按键",
            [10062] = "拍手（玩家 2）",
            [10063] = "康加鼓按键分配：\n分配 玩家 2 拍手按键",
            [10064] = "确认",
            [10065] = "菜单确认按键",
            [10066] = "取消",
            [10067] = "菜单取消按键",
            [10068] = "向左",
            [10069] = "菜单向左按键",
            [10070] = "向右",
            [10071] = "菜单向右按键",

            [10084] = "真打模式",
            [10085] = "系统选项",
            [10086] = "游戏选项",
            [10087] = "退出",
            [10091] = "系统整体设置",
            [10092] = "敲鼓相关设置",
            [10093] = "保存设定并退出设置菜单。",

            [10094] = "左红（玩家 3）",
            [10095] = "鼓按键分配：\n分配玩家 3 左红按键",
            [10096] = "右红玩家 3）",
            [10097] = "鼓按键分配：\n分配玩家 3 右红按键",
            [10098] = "左蓝（玩家 3）",
            [10099] = "鼓按键分配：\n分配玩家 3 左蓝按键",
            [10100] = "右蓝（玩家 3）",
            [10101] = "鼓按键分配：\n分配玩家 3 右蓝按键",

            [10102] = "左红（玩家 4）",
            [10103] = "鼓按键分配：\n分配玩家 4 左红按键",
            [10104] = "右红（玩家 4）",
            [10105] = "鼓按键分配：\n分配玩家 4 右红按键",
            [10106] = "左蓝（玩家 4）",
            [10107] = "鼓按键分配：\n分配玩家 4 左蓝按键",
            [10108] = "右蓝（玩家 4）",
            [10109] = "鼓按键分配：\n分配玩家 4 右蓝按键",

            [10110] = "左红（玩家 5）",
            [10111] = "鼓按键分配：\n分配玩家 5 左红按键",
            [10112] = "右红（玩家 5）",
            [10113] = "鼓按键分配：\n分配玩家 5 右红按键",
            [10114] = "左蓝（玩家 5）",
            [10115] = "鼓按键分配：\n分配玩家 5 左蓝按键",
            [10116] = "右蓝（玩家 5）",
            [10117] = "鼓按键分配：\n分配玩家 5 右蓝按键",

            [10118] = "拍手（玩家 3）",
            [10119] = "康加鼓按键分配：\n分配玩家 3 康加鼓按键",
            [10120] = "拍手（玩家 4）",
            [10121] = "康加鼓按键分配：\n分配玩家 4 康加鼓按键",
            [10122] = "拍手（玩家 5）",
            [10123] = "康加鼓按键分配：\n分配玩家 5 康加鼓按键",
            
            [10124] = "表里谱面切换动画效果",
            [10125] = "播放由皮肤定义的表里谱面切换动画效果。",	
   
            [10126] = "总是使用默认规格（魂条）",
            [10127] = "总是使用默认规格（魂条）",

            [10150] = "视频播放显示模式",
            [10151] = "调整背景视频播放方式。",
	    
            [97] = "截屏",
            [98] = "系统按键分配：\n分配截屏按键。\n（仅可使用键盘，不可使用手柄）",
            [10128] = "提高音量",
            [10129] = "系统按键分配：\n分配提高音乐音量按键。\n（仅可使用键盘，不可使用手柄）",
            [10130] = "降低音量",
            [10131] = "系统按键分配：\n分配降低音乐音量按键。\n（仅可使用键盘，不可使用手柄）",
            [10132] = "显示判定情况",
            [10133] = "系统按键分配：\n分配显示判定情况按键。\n（仅可使用键盘，不可使用手柄）",
            [10134] = "显示调试菜单",
            [10135] = "系统按键分配：\n分配显示调试菜单按键。\n（仅可使用键盘，不可使用手柄）",
            [10136] = "快速设置",
            [10137] = "系统按键分配：\n分配访问快速设置按键。\n（仅可使用键盘，不可使用手柄）",
            [10138] = "玩家自定义",
            [10139] = "系统按键分配：\n分配玩家自定义按键。\n（仅可使用键盘，不可使用手柄）",
            [10140] = "切换歌曲排序方式",
            [10141] = "系统按键分配：\n分配切换歌曲排序方式按键。\n（仅可使用键盘，不可使用手柄）",
            [10142] = "切换自动演奏（玩家 1）",
            [10143] = "系统按键分配：\n分配切换自动演奏（玩家 1）按键。\n（仅可使用键盘，不可使用手柄）",
            [10144] = "切换自动演奏（玩家 2）",
            [10145] = "系统按键分配：\n分配切换自动演奏（玩家 2）按键。\n（仅可使用键盘，不可使用手柄）",
            [10146] = "切换训练模式",
            [10147] = "系统按键分配：\n分配切换训练模式按键。\n（仅可使用键盘，不可使用手柄）",
            [10152] = "循环视频播放显示",
            [10153] = "系统按键分配：\n分配循环视频播放显示模式按键。\n（仅可使用键盘，不可使用手柄）",	

            [10154] = "Measure Skip Count",
            [10155] = "The number of measures to skip while\npressing Skip Forward/Back Measure in\nTraining Mode.",
            [10156] = "Measure Jump Time Interval",
            [10157] = "The amount of time in milliseconds needed to\nrepeatedly hit the Left/Right Blue keys in\norder to jump to a bookmarked measure in\nTraining Mode.",
            [10158] = "Training Mode Key Config",
            [10159] = "A secondary menu to adjust keys used during\nTraining Mode.",

            [10160] = "Pause Training",
            [10161] = "Drums key assign:\nAssign any key for pausing.",
            [10162] = "Toggle Auto",
            [10163] = "Drums key assign:\nAssign any key for toggling auto.",
            [10164] = "Add/Remove Bookmark",
            [10165] = "Drums key assign:\nAssign any key for adding/removing bookmarks.",
            [10166] = "Increase Scroll Speed",
            [10167] = "Drums key assign:\nAssign any key for increasing scroll speed.",
            [10168] = "Decrease Scroll Speed",
            [10169] = "Drums key assign:\nAssign any key for decreasing scroll speed.",
            [10170] = "Increase Song Speed",
            [10171] = "Drums key assign:\nAssign any key for increasing song speed.",
            [10172] = "Decrease Song Speed",
            [10173] = "Drums key assign:\nAssign any key for decreasing song speed.",
            [10174] = "Set Branch to Normal",
            [10175] = "Drums key assign:\nAssign any key for setting a chart's branch\nto normal.",
            [10176] = "Set Branch to Expert",
            [10177] = "Drums key assign:\nAssign any key for setting a chart's branch\nto expert.",
            [10178] = "Set Branch to Master",
            [10179] = "Drums key assign:\nAssign any key for setting a chart's branch\nto master.",
            [10180] = "Move Forward Measure",
            [10181] = "Drums key assign:\nAssign any key for moving forward a measure.",
            [10182] = "Move Back Measure",
            [10183] = "Drums key assign:\nAssign any key for moving back a measure.",
            [10184] = "Skip Forward Measures",
            [10185] = "Drums key assign:\nAssign any key for skipping forward measures.",
            [10186] = "Skip Back Measures",
            [10187] = "Drums key assign:\nAssign any key for skipping back measures.",
            [10188] = "Jump to First Measure",
            [10189] = "Drums key assign:\nAssign any key for jumping to the first measure.",
            [10190] = "Jump to Last Measure",
            [10191] = "Drums key assign:\nAssign any key for jumping to the last measure.",
            // Please translate the text above!

            [100] = "演奏模式",
            [101] = "段位道场",
            [102] = "太鼓塔",
            [103] = "商店",
            [104] = "太鼓冒险",
            [105] = "我的房间",
            [106] = "设置",
            [107] = "退出",
            [108] = "在线大厅",
            [109] = "打开百科",
            [110] = "AI 对战模式",
            [111] = "玩家数据",
            [112] = "谱面编辑器",
            [113] = "打开工具箱",

            [150] = "按照您自己的节奏演奏曲目！",
            [151] = "连续演奏多个谱面并通过挑战测试！",
            [152] = "在限定条命内演奏长谱面并到达塔顶！",
            [153] = "使用游戏中获得的金币购买曲目和角色！",
            [154] = "克服各种障碍来获得新内容！",
            [155] = "更改名牌信息或角色外观！",
            [156] = "更改游戏风格或设置！",
            [157] = "退出游戏，下次再见！",
            [158] = "从网络下载新谱面和内容！",
            [159] = "了解与 OpenTaiko 相关的功能及如何安装新内容！",
            [160] = "与强大的 AI 进行多轮对战并取胜！",
            [161] = "观看并追踪您的进度！",
            [162] = "为您喜爱的乐曲制作 .tja 谱面！",
            [163] = "用多种工具插入自制内容！",

            [200] = "返回",
            [201] = "最近演奏曲目",
            [202] = "选择最近演奏过的曲目！",
            [203] = "随机曲目",

            [300] = "获得金币！",
            [301] = "获得新角色！",
            [302] = "获得迷你角色！",
            [303] = "获得新称号！",
            [304] = "注意",
            [305] = "确认",
            [306] = "金币",
            [307] = "总计",

            [400] = "返回主菜单",
            [401] = "返回",
            [402] = "下载内容",
            [403] = "选择 CDN 服务器",
            [404] = "下载曲目",
            [405] = "下载角色",
            [406] = "下载迷你角色",
            [407] = "在线多人",

            [500] = "时机判断",
            [501] = "非常宽松",
            [502] = "宽松",
            [503] = "一般",
            [504] = "严格",
            [505] = "非常严格",
            [510] = "分数倍率：",
            [511] = "金币倍率：",
            [512] = "游戏类型",
            [513] = "太鼓",
            [514] = "康加鼓",
            [515] = "趣味模组",
            [516] = "雪崩",
            [517] = "扫雷",

            [1000] = "到达楼层",
            [1001] = "层",
            [1002] = "点",
            [1003] = "分数",

            [1010] = "魂条",
            [1011] = "“良”数",
            [1012] = "“可”数",
            [1013] = "“不可”数",
            [1014] = "分数",
            [1015] = "连打数",
            [1016] = "击打数",
            [1017] = "连击",
            [1018] = "准确率",
            [1019] = "隐藏音符",
            [1020] = "踩中地雷",

            [1030] = "返回",
            [1031] = "迷你角色",
            [1032] = "角色",
            [1033] = "段位称号",
            [1034] = "名牌称号",

            [1040] = "简单",
            [1041] = "普通",
            [1042] = "困难",
            [1043] = "魔王（表）",
            [1044] = "魔王（里）",
            [1045] = "魔王（表·里）",

            [90000] = "【错误】未达成条件",
            [90001] = "物品仅在商店可用。",
            [90002] = "奖牌价格：",
            [90003] = "购买成功！",
            [90004] = "金币不足！",
            [90005] = "需求条件：",

            [900] = "继续",
            [901] = "重新开始",
            [902] = "退出",

            [910] = "AI",
            [911] = "机械降神",

            [9000] = "关闭",
            [9001] = "开启",
            [9002] = "无",
            [9003] = "轻度",
            [9004] = "重度",
            [9006] = "特训模式",
            [9007] = "-",
            [9008] = "速度",
            [9009] = "隐藏音符",
            [9010] = "翻转",
            [9011] = "随机",
            [9012] = "游戏模式",
            [9013] = "自动",
            [9014] = "语音",
            [9015] = "音色",
            [9016] = "隐形",
            [9017] = "安全",
            [9018] = "严格",

            [9100] = "搜索（难度）",
            [9101] = "难度",
            [9102] = "等级",

            [9200] = "返回",
            [9201] = "文件路径",
            [9202] = "标题",
            [9203] = "副标题",
            [9204] = "显示等级",
        };
    }
}
