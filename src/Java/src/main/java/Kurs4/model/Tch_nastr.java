package Kurs4.model;

import org.eclipse.persistence.annotations.Convert;
import org.eclipse.persistence.annotations.Converter;
import Kurs4.utils.UUIDConverter;

import javax.persistence.*;
import java.util.UUID;

import com.sap.olingo.jpa.metadata.core.edm.annotation.EdmIgnore;

/**
 * Entity implementation class for Entity: Тч_настр
 */
@Entity(name = "IISKurs4Тч_настр")
@Table(schema = "public", name = "Тч_настр")
public class Tch_nastr {

    @Id
    @Converter(converterClass = UUIDConverter.class, name = "primarykey")
    @Convert("primarykey")
    @Column(name = "primarykey", length = 16, unique = true, nullable = false)
    private UUID primarykey;

    @Column(name = "ТипАтр")
    private String типатр;

    @Column(name = "Атрибут")
    private String атрибут;

    @Column(name = "Ограничение")
    private Integer ограничение;

    @Column(name = "Обязательное")
    private Boolean обязательное;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "NastrKonv")
    @Convert("NastrKonv")
    @Column(name = "НастрКонв", length = 16, unique = true, nullable = false)
    private UUID _nastrkonvid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "NastrKonv", insertable = false, updatable = false)
    private NastrKonv nastrkonv;


    public Tch_nastr() {
        super();
    }

    public void setPrimarykey(UUID primarykey) {
        this.primarykey = primarykey;
    }

    public UUID getPrimarykey() {
        return primarykey;
    }

    public String getТипАтр() {
      return типатр;
    }

    public void setТипАтр(String типатр) {
      this.типатр = типатр;
    }

    public String getАтрибут() {
      return атрибут;
    }

    public void setАтрибут(String атрибут) {
      this.атрибут = атрибут;
    }

    public Integer getОграничение() {
      return ограничение;
    }

    public void setОграничение(Integer ограничение) {
      this.ограничение = ограничение;
    }

    public Boolean getОбязательное() {
      return обязательное;
    }

    public void setОбязательное(Boolean обязательное) {
      this.обязательное = обязательное;
    }


}