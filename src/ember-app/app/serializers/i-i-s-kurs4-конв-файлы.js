import { Serializer as КонвФайлыSerializer } from
  '../mixins/regenerated/serializers/i-i-s-kurs4-конв-файлы';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(КонвФайлыSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
