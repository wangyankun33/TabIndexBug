# TabIndexBug

想实现类似表格头部滚动，内容也跟随滚动的效果。

## 主要问题:
<ol>
  <li>在头部的ScrollView 的Scrolled事件中，无法获得 ItemTemplate 中 ScrollView 的对象，导致无法实现子项滚动。</li>
</ol>
