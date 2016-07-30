package demo.freemarker.util;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Map;

import freemarker.core.ParseException;
import freemarker.template.Configuration;
import freemarker.template.MalformedTemplateNameException;
import freemarker.template.Template;
import freemarker.template.TemplateException;
import freemarker.template.TemplateNotFoundException;
import freemarker.template.Version;

public class FreeMarkerUtil {
    public Template getTemplateByName(String name) {
        Template template = null;
        
        try {
            Configuration configuration = new Configuration(new Version("2.3.23"));
            configuration.setClassForTemplateLoading(this.getClass(), "../template/");
            template = configuration.getTemplate(name);
        } catch (TemplateNotFoundException e) {
            e.printStackTrace();
        } catch (MalformedTemplateNameException e) {
            e.printStackTrace();
        } catch (ParseException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
        
        return template;
    }

    public void showTemplate(String name, Map<String, Object> map) {
        try {
            Template template = this.getTemplateByName(name);
            template.process(map, new PrintWriter(System.out));
        } catch (TemplateException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public void createFile(String templateName, Map<String, Object> map, String fileName) {
        try {
            FileWriter fileWriter = new FileWriter("src/main/java/demo/freemarker/output/" + fileName);
            Template template = this.getTemplateByName(templateName);
            template.process(map, fileWriter);
        } catch (IOException e) {
            e.printStackTrace();
        } catch (TemplateException e) {
            e.printStackTrace();
        }
    }
}