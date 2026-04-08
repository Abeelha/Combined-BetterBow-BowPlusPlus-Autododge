var root = file.rsz.GetEntryObject<App_user_data_Wp11ActionParam>();
var sb = new System.Text.StringBuilder();
sb.AppendLine("{");
DumpObj(sb, root, 1);
sb.AppendLine("}");
File.WriteAllText(@"C:\Users\Abeelha\Desktop\mods\export.json", sb.ToString());
System.Windows.MessageBox.Show("Done! Saved to Desktop\\mods\\export.json");
}

static void DumpObj(System.Text.StringBuilder sb, object obj, int d) {
if (obj == null || d > 8) return;
var ind = new string(' ', d * 2);
var props = obj.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
bool first = true;
foreach (var p in props) {
  if (p.Name == "Index" || p.Name == "Item") continue;
  try {
    var v = p.GetValue(obj);
    if (v == null) continue;
    var t = v.GetType();
    if (!first) sb.AppendLine(",");
    first = false;
    if (t.IsPrimitive || t == typeof(decimal)) {
      sb.Append(ind + "\"" + p.Name + "\": " + Convert.ToString(v, System.Globalization.CultureInfo.InvariantCulture));
    } else if (t == typeof(string) || t.IsEnum) {
      sb.Append(ind + "\"" + p.Name + "\": \"" + v + "\"");
    } else if (v is System.Collections.IList list) {
      sb.AppendLine(ind + "\"" + p.Name + "\": [");
      for (int i = 0; i < list.Count; i++) {
        var item = list[i];
        if (item != null && !item.GetType().IsPrimitive && item.GetType() != typeof(string)) {
          sb.AppendLine(ind + "  {");
          DumpObj(sb, item, d + 2);
          sb.AppendLine();
          sb.Append(ind + "  }" + (i < list.Count - 1 ? "," : ""));
        } else {
          sb.Append(ind + "  " + Convert.ToString(item, System.Globalization.CultureInfo.InvariantCulture) + (i < list.Count - 1 ? "," : ""));
        }
      }
      sb.Append("\n" + ind + "]");
    } else {
      sb.AppendLine(ind + "\"" + p.Name + "\": {");
      DumpObj(sb, v, d + 1);
      sb.AppendLine();
      sb.Append(ind + "}");
    }
  } catch { }
}
