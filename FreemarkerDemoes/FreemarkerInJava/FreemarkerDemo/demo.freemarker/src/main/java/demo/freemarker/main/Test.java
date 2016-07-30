package demo.freemarker.main;

import java.util.HashMap;
import java.util.Map;

import demo.freemarker.util.FreeMarkerUtil;

public class Test {

    public static void main(String[] args) {
        FreeMarkerUtil freeMarkerUtil = new FreeMarkerUtil();
        Map<String, Object> map = new HashMap<String, Object>();
        map.put("userName", "Test User");
        freeMarkerUtil.showTemplate("01.ftl", map);
        freeMarkerUtil.createFile("01.ftl", map, "01.html");
    }

}
