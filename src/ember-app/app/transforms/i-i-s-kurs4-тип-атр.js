import FlexberryEnum from 'ember-flexberry-data/transforms/flexberry-enum';
import ТипАтрEnum from '../enums/i-i-s-kurs4-тип-атр';

export default FlexberryEnum.extend({
  enum: ТипАтрEnum,
  sourceType: 'IIS.Kurs4.ТипАтр'
});
