import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  имяДок: DS.attr('string'),
  загрФайла: DS.belongsTo('i-i-s-kurs4-загр-файла', { inverse: null, async: false }),
  настрКонв: DS.belongsTo('i-i-s-kurs4-настр-конв', { inverse: null, async: false })
});

export let ValidationRules = {
  имяДок: {
    descriptionKey: 'models.i-i-s-kurs4-конвертация.validations.имяДок.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  загрФайла: {
    descriptionKey: 'models.i-i-s-kurs4-конвертация.validations.загрФайла.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  настрКонв: {
    descriptionKey: 'models.i-i-s-kurs4-конвертация.validations.настрКонв.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('КонвертацияE', 'i-i-s-kurs4-конвертация', {
    имяДок: attr('Имя док', { index: 0 }),
    загрФайла: belongsTo('i-i-s-kurs4-загр-файла', 'Загрузка файла', {
      путь: attr('Путь', { index: 2, hidden: true })
    }, { index: 1, displayMemberPath: 'путь' }),
    настрКонв: belongsTo('i-i-s-kurs4-настр-конв', 'Настройки конвертации', {
      наименование: attr('Наименование', { index: 4, hidden: true })
    }, { index: 3, displayMemberPath: 'наименование' })
  });

  modelClass.defineProjection('КонвертацияL', 'i-i-s-kurs4-конвертация', {
    имяДок: attr('Имя док', { index: 0 }),
    загрФайла: belongsTo('i-i-s-kurs4-загр-файла', 'Загрузка файла', {
      путь: attr('Загрузка файла', { index: 1 })
    }, { index: -1, hidden: true }),
    настрКонв: belongsTo('i-i-s-kurs4-настр-конв', 'Настройка', {
      наименование: attr('Настройка', { index: 2 })
    }, { index: -1, hidden: true })
  });
};
