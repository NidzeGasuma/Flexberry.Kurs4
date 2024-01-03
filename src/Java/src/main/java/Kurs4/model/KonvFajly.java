package Kurs4.model;

import org.eclipse.persistence.annotations.Convert;
import org.eclipse.persistence.annotations.Converter;
import Kurs4.utils.UUIDConverter;

import javax.persistence.*;
import java.util.UUID;

import com.sap.olingo.jpa.metadata.core.edm.annotation.EdmIgnore;

/**
 * Entity implementation class for Entity: КонвФайлы
 */
@Entity(name = "IISKurs4КонвФайлы")
@Table(schema = "public", name = "КонвФайлы")
public class KonvFajly {

    @Id
    @Converter(converterClass = UUIDConverter.class, name = "primarykey")
    @Convert("primarykey")
    @Column(name = "primarykey", length = 16, unique = true, nullable = false)
    private UUID primarykey;

    @Column(name = "ПутьФайла")
    private String путьфайла;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "VygrFajla")
    @Convert("VygrFajla")
    @Column(name = "ВыгрФайла", length = 16, unique = true, nullable = false)
    private UUID _vygrfajlaid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "VygrFajla", insertable = false, updatable = false)
    private VygrFajla vygrfajla;


    public KonvFajly() {
        super();
    }

    public void setPrimarykey(UUID primarykey) {
        this.primarykey = primarykey;
    }

    public UUID getPrimarykey() {
        return primarykey;
    }

    public String getПутьФайла() {
      return путьфайла;
    }

    public void setПутьФайла(String путьфайла) {
      this.путьфайла = путьфайла;
    }


}