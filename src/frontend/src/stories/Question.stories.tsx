import { Meta, Story } from "@storybook/react/types-6-0";
import Question from "../components/Question";

export default {
    title: "components/Question",
    components: Question,
} as Meta;

const Template: Story = () => <Question />;

export const Default = Template.bind({});